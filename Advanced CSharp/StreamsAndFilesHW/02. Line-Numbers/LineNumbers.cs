namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        private static void Main()
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(@"..\..\LineNumbers.cs", Encoding.GetEncoding("windows-1251"));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            try
            {
                writer = new StreamWriter(@"..\..\LineNumbers.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to create output file.");
            }

            string s;
            int lineNumber = 1;
            using (reader)
            using (writer)
            {
                do
                {
                    s = reader.ReadLine();
                    writer.WriteLine("{0} {1}", lineNumber, s);
                    lineNumber++;
                }
                while (s != null);
            }

            Console.WriteLine("Task complete:\n");

            string fileContents = File.ReadAllText(@"..\..\LineNumbers.txt");
            Console.WriteLine(fileContents);
        }
    }
}