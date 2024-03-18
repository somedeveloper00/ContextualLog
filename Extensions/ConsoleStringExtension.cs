using System;

namespace ContextualLog.Extensions
{
    /// <summary>
    /// Makes it so console logs (including unity logs when using stdout) have a foreground color
    /// </summary>
    public readonly struct ConsoleForegroundColor : IDisposable
    {
        private readonly ConsoleColor _prevCol;

        public ConsoleForegroundColor(ConsoleColor color)
        {
            _prevCol = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }

        public readonly void Dispose()
        {
            Console.ForegroundColor = _prevCol;
        }
    }

    /// <summary>
    /// Makes it so console logs (including unity logs when using stdout) have a background color
    /// </summary>
    public readonly struct ConsoleBackgroundColor : IDisposable
    {
        private readonly ConsoleColor _prevCol;

        public ConsoleBackgroundColor(ConsoleColor color)
        {
            _prevCol = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }

        public readonly void Dispose()
        {
            Console.BackgroundColor = _prevCol;
        }
    }
}