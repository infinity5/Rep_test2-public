using System;
using System.IO;
namespace WorkingWithStreams
{
    class Program
    {
        // define an array of Viper pilot call signs
        static string[] callsigns = new string[] {
 "Paraschiv", "Starbuck", "Apollo", "Boomer",
 "Bulldog", "Athena", "Helo", "Racetrack" };

        static void WorkWithText()
        {
            // define a file to write to
            string textFile = Path.Combine(Directory.GetCurrentDirectory(), "streams.txt");
            // create a text file and return a helper writer 
            StreamWriter text = File.CreateText(textFile);
            // enumerate the strings, writing each one
            // to the stream on a separate line 
            foreach (string item in callsigns)
            {
                text.WriteLine(item);
            }
            text.Close(); // release resources
                          // output the contents of the file 
            Console.WriteLine("{0} contains {1:N0} bytes.",
            arg0: textFile,
            arg1: new FileInfo(textFile).Length);
            Console.WriteLine(File.ReadAllText(textFile));
        }
        static void WorkWithXml()
        {
            // define a file to write to

            static void Main(string[] args)
        {
            WorkWithText();
            Console.WriteLine("Hello World!");
        }
    }
}
