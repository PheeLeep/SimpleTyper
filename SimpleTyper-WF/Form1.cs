namespace SimpleTyper_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (!SimpleTyper.SimpleTyper.IsRunning)
                OutputRTB.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SimpleTyper.SimpleTyper.IsRunningStatusChanged += SimpleTyper_IsRunningStatusChanged;
            SimpleTyper.SimpleTyper.SendCharacter += SimpleTyper_SendCharacter;
        }

        private void SimpleTyper_SendCharacter(char character)
        {
            try
            {
                Invoke(new Action(() => OutputRTB.AppendText(character.ToString())));
            }
            catch
            {
                // Ignore.
            }
        }

        private void SimpleTyper_IsRunningStatusChanged()
        {
            try
            {
                Invoke(new Action(() =>
                {
                    StartStopButton.Text = SimpleTyper.SimpleTyper.IsRunning ? "Stop" : "Start";
                    ClearButton.Enabled = !SimpleTyper.SimpleTyper.IsRunning;
                    InputRTB.ReadOnly = SimpleTyper.SimpleTyper.IsRunning;
                    WaitTimeNUP.Enabled = !SimpleTyper.SimpleTyper.IsRunning;
                    ReverseTypeCBox.Enabled = !SimpleTyper.SimpleTyper.IsRunning;
                }));
            }
            catch
            {
                // Ignore.
            }
        }

        private void WaitTimeNUP_ValueChanged(object sender, EventArgs e)
        {
            if (!SimpleTyper.SimpleTyper.IsRunning)
                SimpleTyper.SimpleTyper.WaitTime = (int)WaitTimeNUP.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SimpleTyper.SimpleTyper.IsRunning)
                SimpleTyper.SimpleTyper.Stop();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (SimpleTyper.SimpleTyper.IsRunning)
            {
                SimpleTyper.SimpleTyper.Stop();
                return;
            }
            SimpleTyper.SimpleTyper.StartType(InputRTB.Text, ReverseTypeCBox.Checked);
        }
    }
}