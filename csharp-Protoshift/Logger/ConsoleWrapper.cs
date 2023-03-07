namespace YYHEggEgg.Logger
{
    public static class ConsoleWrapper
    {
        public static void Write(string str)
        {

        }

        public static void WriteLine(string str)
            => Write($"{str}{Environment.NewLine}");

        public int RefreshCUITicks { get; set; }
        public string UserInputPrefix { get; set; }
        public event Action<string> UserInputArrived;

        private Minqueue<string> WrittenLines;
        private Minqueue<string> 

        private void BackgroundUpdate
        {

        }


    }
}