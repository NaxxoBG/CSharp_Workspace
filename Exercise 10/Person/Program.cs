using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.SavePersonToFile("Tim", "Johnson", 124423);

            Console.WriteLine(Person.ReadPersonFromFile());
        }
    }
}