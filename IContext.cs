namespace ContextualLog
{
    /// <summary>
    /// a simple context interface to provide a printable name for the context
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// returns the parent context. null if there's no parent context
        /// </summary>
        IContext GetParentContext();

        /// <summary>
        /// returns the printable name of the context
        /// </summary>
        string GetPrintableContextName();
    }
}