namespace CopyBinaryFile
{
    using System.Diagnostics;
    using System.IO;

    public class CopyBinaryFile
    {
        private const string NImagePath = "../../text.txt";

        private const string DestinationPath = "../../result.txt";

        public static void Main()
        {
            using (var source = new FileStream(NImagePath, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath, FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }

            Process.Start(@"..\..\result.txt");
        }
    }
}