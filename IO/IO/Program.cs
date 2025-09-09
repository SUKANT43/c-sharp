

//wtrite
/*class Program
{
    static void Main()
    {
        string path = "example.txt";
        string content = "Hello, this is written using File I/O in C#!";

        File.WriteAllText(path, content);

        Console.WriteLine("Data written to file successfully!");
    }
}*/

//read
/*class Program
{
    static void Main()
    {
        string path = "example.txt";

        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);

        }
        else
        {
            Console.WriteLine("File not found!");
       
        }
        Console.ReadLine();
    }
}*/

//appending to a file
/*using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "example.txt";
        string newLine = "This is a new line appended.";

        File.AppendAllText(path, Environment.NewLine + newLine);

        Console.WriteLine("New line appended!");
    }
}*/






/*using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "data.txt";

        // Write using StreamWriter
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("Line 1");
            sw.WriteLine("Line 2");
            sw.WriteLine("Line 3");
        }

        // Read using StreamReader
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}*/
