using System;

namespace StreamReader_StreamWriter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the methods
            String filePath = "text.txt";

            // call stream writer method
            stream_writer_file w = new stream_writer_file();
            w.WriteToFile(filePath);

            // call stream reader method
            stream_reader_file r = new stream_reader_file();
            r.ReadToFile(filePath);
        }
    }
}
