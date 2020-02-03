using System;
using System.IO;
using System.Linq;

namespace sample_learning_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowlargestFileWithLinQ();
            Console.WriteLine("Hello World!");
        }

        private static void ShowlargestFileWithLinQ()
        {
            var path = @"C:\Angular\Angular Forms";
            var listOfFiles = from file in new DirectoryInfo(path).GetFiles()
                              orderby file.Length descending
                              select file;
            foreach (var item in listOfFiles.Take(5))
            {
                Console.WriteLine($"Name: {item.Name}; Size: {item.Length}");
            }
        }
    }
}
