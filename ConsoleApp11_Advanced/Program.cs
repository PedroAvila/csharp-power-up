using System;
using System.Collections.Generic;

namespace ConsoleApp11_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine("Args: {0}", args[i]);

            Console.Title = "Comprensión de los métodos de indexación";

            int[] myInts = { 10, 9, 100, 432, 9874 };

            for (int j = 0; j < myInts.Length; j++)
                Console.WriteLine("Index {0} = {1} ", j, myInts[j]);

            UseGenericListOfPeople();

            Console.ReadLine();


        }

        static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person() { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            myPeople.Add(new Person() { FirstName = "Bart", LastName = "Simpson", Age = 7 });

            myPeople[0] = new Person() { FirstName = "Maggie", LastName = "Simpson", Age = 2 };

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
        }
    }
}
