using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FILES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "old.cs";
            string text;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    text = sr.ReadToEnd();
                }
            }
            text = text.Replace("public", "private");
            using (FileStream fs = new FileStream("new.cs", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(fs)) {
                sw.WriteLine(text);
                }
                Console.WriteLine("Text is sucessfully coppied and replaced!");
                Console.ReadKey();
            }
        }
    }
}
