using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_query_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string collection
            List<string> strings = new List<string>()
            {
                "C# tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" +
                "Java"
            };

            // LINQ query syntax
            var result = from s in strings
                         where s.Contains("Tutorials")
                         select s;

            foreach(var str in result) Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
