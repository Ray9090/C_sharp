using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StreamReader_StreamWriter_Example
{
    class stream_writer_file
    {
        public void WriteToFile(string filePath)
        {
            ////code to write text file using StreamWriter
            StreamWriter writer = new StreamWriter(filePath, true);
            String temp = String.Empty;

            // this loop terminate the reading process if user enter 0
            do
            {
                Console.Write("Enter a name[0 to exit]: ");
                temp = Console.ReadLine();

                // this loop will not send -1 to text file
                if (temp != "0")
                {
                    writer.WriteLine(temp);
                }

            } while (temp != "0"); // termination condition

            writer.Close();

        }
    }
}
