using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Glot;
using Glot.Models;

namespace GlotTesting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (!System.IO.File.Exists("glotkey.txt"))
            {
                Console.Write("Enter API Key For Glot.IO: ");
                System.IO.File.WriteAllText("glotkey.txt", Console.ReadLine());
            }
            var glotkey = System.IO.File.ReadAllText("glotkey.txt");

            var glotrunner = new GlotRunner(glotkey);
            foreach (var lang in await glotrunner.GetLanguagesAsync())
            {
                Console.WriteLine(lang.Name);
            }

            var runresult = await glotrunner.RunCodeAsync("csharp", new RunCode
            {
                Files = new List<File>()
                {
                    new File
                    {
                        Name = "Program.cs",
                        Content = "public class idk { public static void Main(string[] args) => System.Console.WriteLine(\"Hello World\"); }"
                    }
                }
            });
            Console.WriteLine(runresult.Stdout);
        }
    }
}