using System.Collections.Concurrent;
using System.Text;

namespace YYHEggEgg.Logger
{
    public class ConsoleWrapper
    {
        private static List<string> lines; // 记录每行输入的列表
        private static int currentLine; // 当前所在行的标记
        private static ConcurrentQueue<string> readqueue = new();
        public static event EventHandler? ShutDown; // 退出事件

        private static bool isReading;
        private static bool AddPrefix;
        public static int RefreshTicks { get; set; }
        private static StringBuilder input;
        private static int cursor;

        static ConsoleWrapper()
        {
            lines = new List<string>();
            currentLine = 0;
            Console.CancelKeyPress += Console_CancelKeyPress;
            InputPrefix = "";
            RefreshTicks = 10;

            Console.TreatControlCAsInput = true; // 允许Ctrl+C被视为输入
            input = new();
            cursor = 0;

            Task.Run(BackgroundUpdate);
        }

        private static void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            ShutDown?.Invoke(null, EventArgs.Empty);
        }

        #region Refresh Prefix
        // Reference:
        // [ Can Console.Clear be used to only clear a line instead of whole console? ]
        // https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
        // Applied some modifications to support only clear current line.
        private static void ClearThisLine()
        {
            // if (Console.CursorTop > 0) Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static string InputPrefix { get; set; }
        private static object PrefixLock = "YYHEggEgg.Logger";

        public static async Task<string> ReadLineAsync()
        {
            lock (PrefixLock)
            {
                isReading = true;
                AddPrefix = true;
                ClearWrittingArea();
                Console.Write(InputPrefix);
            }

            string? result;
            while (!readqueue.TryDequeue(out result))
            {
                await Task.Delay(RefreshTicks);
            }

            lock (PrefixLock)
            {
                AddPrefix = false;
                isReading = false;
            }

            return result;
        }

        public static void BeginWrite()
        {
            lock (PrefixLock)
            {
                if (isReading)
                {
                    ClearWrittingArea();
                    AddPrefix = false;
                }
            }
        }

        public static void EndWrite()
        {
            lock (PrefixLock)
            {
                AddPrefix = true;
                Console.Write(InputPrefix);
                if (isReading) Console.Write(input);
            }
        }

        private static void ClearWrittingArea()
        {
            int occupiedLength = InputPrefix.Length + input.Length;
            while (occupiedLength > 0)
            {
                ClearThisLine();
                occupiedLength -= Console.WindowWidth;
                if (occupiedLength > 0)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
            }
        }
        #endregion

        public static async Task BackgroundUpdate()
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(!isReading);
            #region 清除整行的操作
            if (keyInfo.Key == ConsoleKey.Enter) // 整合输入的所有字符
            {
                lines.Add(input.ToString());
                readqueue.Enqueue(input.ToString());
                currentLine = lines.Count;
                input = new();
                cursor = 0;

                lock (PrefixLock)
                {
                    Console.Write(InputPrefix);
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow) // 切换cursor至上一行
            {
                if (currentLine > 0)
                {
                    currentLine--;
                    input = new(lines[currentLine]);
                    cursor = input.Length;

                    lock (PrefixLock)
                    {
                        ClearWrittingArea();
                        Console.Write(InputPrefix);
                        if (isReading) Console.Write(input);
                    }
                }
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow) // 切换cursor至下一行
            {
                if (currentLine < lines.Count - 1)
                {
                    currentLine++;
                    input = new(lines[currentLine]);
                    cursor = input.Length;

                    lock (PrefixLock)
                    {
                        ClearWrittingArea();
                        Console.Write(InputPrefix);
                        if (isReading) Console.Write(input);
                    }
                }
            }
            #endregion
            else if (
                keyInfo.Key == ConsoleKey.C && keyInfo.Modifiers == ConsoleModifiers.Control
            ) // 触发ShutDown事件
            {
                ShutDown?.Invoke(null, EventArgs.Empty);
                return;
            }
            #region 主要处理光标的操作
            else if (
                keyInfo.Key == ConsoleKey.V && keyInfo.Modifiers == ConsoleModifiers.Control
            ) // 粘贴剪贴板内容
            {
                // Automatically handled by .NET Console
                //pasteText = Clipboard.GetText();
                //isCtrlV = true;
            }
            else if (keyInfo.Key == ConsoleKey.Backspace) // 处理退格
            {
                if (input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    cursor = input.Length;
                    // 按下 backspace 后，控制台会自动使光标后退一格，但不删除字符
                    int currentCursorLeft = Console.CursorLeft;
                    int currentCursorTop = Console.CursorTop;
                    Console.Write(' ');
                    Console.SetCursorPosition(currentCursorLeft, currentCursorTop);
                }
            }
            else if (keyInfo.Key == ConsoleKey.Home)
            {
                cursor = 0;
            }
            else if (keyInfo.Key == ConsoleKey.End)
            {
                cursor = input.Length;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (cursor > 0)
                {
                    cursor--;
                    #region 控制台光标操作
                    // 按下上下左右键后，控制台光标不移动
                    int currentCursorLeft = Console.CursorLeft;
                    int currentCursorTop = Console.CursorTop;
                    if (currentCursorLeft == 0)
                        Console.SetCursorPosition(Console.WindowWidth, currentCursorTop - 1);
                    else
                        Console.SetCursorPosition(currentCursorLeft - 1, currentCursorTop);
                    #endregion
                }
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (cursor < input.Length)
                {
                    cursor++;
                    #region 控制台光标操作
                    // 按下上下左右键后，控制台光标不移动
                    int currentCursorLeft = Console.CursorLeft;
                    int currentCursorTop = Console.CursorTop;
                    if (currentCursorLeft == Console.WindowWidth)
                        Console.SetCursorPosition(0, currentCursorTop + 1);
                    else
                        Console.SetCursorPosition(currentCursorLeft + 1, currentCursorTop);
                    #endregion
                }
            }
            #endregion
            else
            {
                input.Insert(cursor, keyInfo.KeyChar);
                cursor++;
            }

            await Task.Run(BackgroundUpdate);
        }
    }
}