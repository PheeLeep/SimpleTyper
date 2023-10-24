namespace SimpleTyper
{

    public delegate void SendCharacterDelegate(char character);
    public delegate void IsRunningStatusChangedDelegate();

    /// <summary>
    /// A static class that simulates typing from the text provided.
    /// </summary>
    public static class SimpleTyper
    {
        private static readonly object _lock = new object();
        private static int _waitTimer = 100;
        private static bool _isRunning = false;

        /// <summary>
        /// Fires an event when a character from a text will be send.
        /// </summary>
        public static event SendCharacterDelegate? SendCharacter;

        /// <summary>
        /// Fires an event when the <see cref="IsRunning"/> value was changed.
        /// </summary>
        public static event IsRunningStatusChangedDelegate? IsRunningStatusChanged;

        /// <summary>
        /// Gets whether the typing is running.
        /// </summary>
        public static bool IsRunning
        {
            get => _isRunning;
            private set
            {
                if (_isRunning == value) return;
                _isRunning = value;
                IsRunningStatusChanged?.Invoke();
            }
        }

        /// <summary>
        /// Gets or sets the value in milliseconds to wait until the next character to type.
        /// </summary>
        /// <remarks>
        /// Setting a value while the typing is ongoing will be discarded.
        /// </remarks>
        public static int WaitTime
        {
            get => _waitTimer;
            set
            {
                if (IsRunning) return;
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Value cannot be negative or zero.");
                _waitTimer = value;
            }
        }

        /// <summary>
        /// Starts typing the text in a thread background.
        /// </summary>
        /// <param name="text">A text provided to send each character to type.</param>
        /// <param name="reverseType">Sets true to reverse typing the text.</param>
        public static void StartType(string text, bool reverseType = false)
        {
            lock (_lock)
            {
                if (IsRunning) return;
                IsRunning = true;
                new Thread(() => ThreadStartType(text, reverseType)).Start();
            }
        }

        /// <summary>
        /// Stops the text typing.
        /// </summary>
        public static void Stop()
        {
            lock (_lock)
            {
                if (!IsRunning) return;
                IsRunning = false;
            }
        }

        /// <summary>
        /// Sends the message to an event in each character.
        /// </summary>
        /// <param name="message">A text provided to send each character to type.</param>
        /// <param name="reverseType">Sets true to reverse typing the text.</param>
        private static void ThreadStartType(string message, bool reverseType)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                IsRunning = false;
                return;
            }

            int current = !reverseType ? 0 : message.Length - 1;
            int end = !reverseType ? message.Length : -1;

            while (IsRunning)
            {
                SendCharacter?.Invoke(message[current]);

                current = reverseType ? current - 1 : current + 1;

                if (current == end)
                {
                    IsRunning = false;
                    continue;
                }

                Thread.Sleep(_waitTimer);
            }
        }
    }
}
