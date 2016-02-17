namespace Empire.Contracts
{
    /// <summary>
    /// The InputReader Interface.
    /// </summary>
    public interface IInputReader
    {
        /// <summary>
        /// Read the commands from the console.
        /// </summary>
        /// <returns></returns>
        string ReadCommand();
    }
}