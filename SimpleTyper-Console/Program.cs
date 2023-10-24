namespace SimpleTyper_Console
{
    internal class Program
    {

        private static string[] lists =
        {
            "Hello World!",
            "It's nice to meet you!",
            "This is a test."
        };

        static void Main(string[] args)
        {
            Console.Title = "SimpleTyper Console.";
            SimpleTyper.SimpleTyper.SendCharacter += SimpleTyper_SendCharacter;
            SimpleTyper.SimpleTyper.WaitTime = 50;
            bool _isPausedEachLine = true;

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "--time":
                            if ((i + 1) >= args.Length)
                            {
                                Console.WriteLine("No specified wait time set.");
                                return;
                            }
                            try
                            {
                                SimpleTyper.SimpleTyper.WaitTime = int.Parse(args[i + 1]);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Failed to parse: {ex.Message}");
                                return;
                            }
                            i++;
                            break;
                        case "--lorem":
                            lists = Properties.Resources.LoremIpsum.Split(new string[] { "\n", "\r\n" },
                                                                          StringSplitOptions.RemoveEmptyEntries);
                            break;
                        case "--unpause":
                            _isPausedEachLine = false;
                            break;
                        case "--help":
                            Console.WriteLine(Properties.Resources.Help);
                            return;
                        default:
                            Console.WriteLine($"Invalid parameter found '{args[i]}'.");
                            return;
                    }
                }
            }

            for (int i = 0; i < lists.Length; i++)
            {
                SimpleTyper.SimpleTyper.StartType(lists[i]);
                while (SimpleTyper.SimpleTyper.IsRunning)
                    Thread.Sleep(100);

                if (_isPausedEachLine) 
                    Console.ReadKey();
                Console.Write("\n");
            }
        }

        private static void SimpleTyper_SendCharacter(char character)
        {
            Console.Write(character);
        }
    }
}