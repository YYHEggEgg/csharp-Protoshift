namespace YYHEggEgg.Logger
{
    public class OperationLine
    {
        private StringBuilder strvalue;
        /// <summary>
        /// If the strvalue has operation char, e.g. Ctrl+C, Enter.
        /// </summary>
        public bool IsOperationValue { get; private set; }
        public int CursorLocation { get; private set; }
        public ConsoleModifiers? OperationModifier { get; private set; }
        public ConsoleKey? OperationKey { get; private set; }

        public OperaionLine(string initstr = "")
        {
            strvalue = new(initstr);
            IsOperationValue = false;
            CursorLocation = 0;
            OperationModifier = null;
            OperationKey = null;
        }

        /// <summary>
        /// Get a key from <see cref="Console.ReadKey()"/>.
        /// </summary>
        /// <returns>If the key doesn't need special handle. If false, please check <see cref="IsOperationValue"/>.</returns>
        public bool ReadKey()
        {
            var keyinfo = Console.ReadKey();
            
            if ((keyinfo.Modifiers & ConsoleModifiers.Control) != 0
                && (keyinfo.Modifiers & ConsoleModifiers.Shift) == 0
                && (keyinfo.Modifiers & ConsoleModifiers.Alt) == 0
                && (keyinfo.Key == ConsoleKey.C // Ctrl+C
                    || keyinfo.Key == ConsoleKey.Z // Ctrl+Z
                    || keyinfo.Key == ConsoleKey.D)) // EOF
            {
                OperationModifier = KeyModifiers.Control;
                OperationKey = keyinfo.Key;
                IsOperationValue = true;
                return false;
            }
            // Enter
            else if (keyinfo.Key == ConsoleKey.Enter)
            {
                OperationKey = ConsoleKey.Enter;
                IsOperationValue = true;
                return false;
            }
            else if ((keyinfo.Modifiers & ConsoleModifiers.Control) != 0
                && (keyinfo.Modifiers & ConsoleModifiers.Alt) == 0
                && (keyinfo.Key == ConsoleKey.A // Ctrl(+SHIFT)+A
                    || keyinfo.Key == ConsoleKey.V)) // Ctrl(+SHIFT)+V
            {
                OperationModifier = keyinfo.Modifiers;
                OperationKey = keyinfo.Key;
                IsOperationValue = true;
                return false;
            }
            else if (keyinfo.Key == ConsoleKey.LeftArrow)
            {
                if (CursorLocation > 0) CursorLocation -= 1;
            }
            else if (keyinfo.Key == ConsoleKey.RightArrow)
            {
                if (CursorLocation < strvalue.Length - 1) CursorLocation += 1;
            }
            else if (keyinfo.Key == ConsoleKey.UpArrow
                || keyinfo.Key == ConsoleKey.DownArrow)
            {
                OperationKey = keyinfo.Key;
                IsOperationValue = true;
                return false;
            }
        }
    }
}