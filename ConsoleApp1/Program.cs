using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.parse("john");
            person.Introduce("Mosh");
        }
    }

    public class Person
    {
        string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I'm {1}", to, Name);
        }

        public static Person parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
}
