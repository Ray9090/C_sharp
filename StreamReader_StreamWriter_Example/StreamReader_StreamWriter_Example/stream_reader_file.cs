using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StreamReader_StreamWriter_Example
{
    class stream_reader_file
    {
        public void ReadToFile(string filePath)
        {
            //code to read text file using StreamReader
            StreamReader reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }
    }
}
