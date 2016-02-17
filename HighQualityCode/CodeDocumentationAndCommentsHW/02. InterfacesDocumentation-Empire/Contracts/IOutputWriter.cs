namespace Empire.Contracts
{
    /// <summary>
    /// The Output Interface.
    /// </summary>
    public interface IOutputWriter
    {
        /// <summary>
        /// Prints the game content in the console.
        /// </summary>
        /// <param name="message">The message.</param>
        void Print(string message);
    }
}