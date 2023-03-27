using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace FileReadWriteExample;

internal class Program
{
    static void Main(string[] args)
    {
        string data;
        StreamReader reader = null;

        try
        {
            reader = new StreamReader(SpecialDirectories.MyDocuments + "\\goodboy.txt");
            data = reader.ReadLine();

            while(data != null)
            {
                Console.WriteLine(data);
                data = reader.ReadLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            reader.Close();
        }
    }
}