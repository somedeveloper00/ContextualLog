using System;
using UnityEngine;
#if !UNITY_EDITOR
using ContextualLog.Extensions;
#endif

namespace ContextualLog.Implementations
{
    /// <summary>
    /// A simple <see cref="IContextLog"/> implementation that uses ANSI color codes to color the console output, as well as 
    /// using <see cref="Debug"/> class so that the logs appear in Unity console.
    /// </summary>
    public struct ColoredConsoleLogger : IContextLog
    {
        public readonly void LogMessage(IContext context, string msg)
        {
            string message = $"[{DateTime.UtcNow} {context.GetPrintableContextNamesRecursive("/")}] {msg}";
#if UNITY_EDITOR
            Debug.LogError(message);
#else
            using (new ConsoleForegroundColor(ConsoleColor.Green))
                Console.WriteLine(message);
#endif
        }

        public readonly void LogWarning(IContext context, string msg)
        {
            string message = $"[{DateTime.UtcNow} {context.GetPrintableContextNamesRecursive("/")}] {msg}";
#if UNITY_EDITOR
            Debug.LogError(message);
#else
            using (new ConsoleForegroundColor(ConsoleColor.Yellow))
                Console.WriteLine(message);
#endif
        }

        public readonly void LogError(IContext context, string msg)
        {
            string message = $"[{DateTime.UtcNow} {context.GetPrintableContextNamesRecursive("/")}] {msg}";
#if UNITY_EDITOR
            Debug.LogError(message);
#else
            using (new ConsoleForegroundColor(ConsoleColor.Red))
                Console.WriteLine(message);
#endif
        }

        public readonly void LogException(IContext context, Exception exception)
        {
            LogError(context, $"{exception.GetType()}: {exception.Message}\n{exception.StackTrace}");
        }
    }
}