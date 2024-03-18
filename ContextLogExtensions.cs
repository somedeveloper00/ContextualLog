using System;
using System.Collections.Generic;

namespace ContextualLog
{
    public static class ContextLogExtensions
    {
        /// <inheritdoc cref="IContextLog.LogMessage(IContext, string)"/>
        public static void LogMessage(this IContext context, IContextLog log, string msg) => log.LogMessage(context, msg);

        /// <inheritdoc cref="IContextLog.LogWarning(IContext, string)"/>
        public static void LogWarning(this IContext context, IContextLog log, string msg) => log.LogWarning(context, msg);

        /// <inheritdoc cref="IContextLog.LogError(IContext, string)"/>
        public static void LogError(this IContext context, IContextLog log, string msg) => log.LogError(context, msg);

        /// <inheritdoc cref="IContextLog.LogException(IContext, Exception)"/>
        public static void LogException(this IContext context, IContextLog log, Exception exception) =>
            log.LogException(context, exception);

        /// <summary>
        /// returns the printable name of the context, including all parent contexts separated by the given <paramref name="separator"/>
        /// </summary>
        public static string GetPrintableContextNamesRecursive(this IContext context, string separator)
        {
            var result = new List<string>();
            while (context != null)
            {
                result.Add(context.GetPrintableContextName());
                context = context.GetParentContext();
            }
            result.Reverse();
            return string.Join(separator, result);
        }
    }
}