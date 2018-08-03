using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using QuickType;

namespace JasonToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //var people = new List<Person>();
            var file = @"C:\Users\alexa\OneDrive\Documents\job\Vertmarkets\Subscribers.json";
            var json = File.ReadAllText(file);           

            var welcome = Welcome.FromJson(json);
            var people = welcome.Data.ToList();
            foreach (Person per in people)
            {
                Console.WriteLine(per.FirstName);
            }
            
            Console.ReadLine();
        }
    }
}
