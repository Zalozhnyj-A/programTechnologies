using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persona = new Person(10, 10, "qwe", "ert", DateTime.Parse("12.12.12"));
            persona.ChangeHeight(12);
            Console.WriteLine(persona.BirthDay);
        }
    }
}
