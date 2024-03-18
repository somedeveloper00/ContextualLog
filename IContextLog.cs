using System;

namespace ContextualLog
{
    /// <summary>
    /// A simple logging interface to provide room for all important logs given the context
    /// </summary>
    public interface IContextLog
    {
        /// <summary>
        /// Log a message
        /// </summary>
        void LogMessage(IContext context, string msg);

        /// <summary>
        /// Log a warning
        /// </summary>
        void LogWarning(IContext context, string msg);

        /// <summary>
        /// Log an error. for <see cref="Exception"/>s, use <see cref="LogException(IContext,Exception)"/>
        /// </summary>
        void LogError(IContext context, string msg);

        /// <summary>
        /// Log an exception
        /// </summary>
        void LogException(IContext context, Exception exception);
    }
}