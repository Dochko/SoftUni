namespace CohesionAndCoupling.Utilities.FileUtilities
{
    /// <summary>
    /// A class which contains utilities for displaying file names.
    /// </summary>
    public static class FileUtilities
    {
        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="fileName">Name of the file extension.</param>
        /// <returns>The extension of the file</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Gets the file name without extension.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>Returns the file name without extension.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}