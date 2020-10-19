using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Comparing_Objects
{
  public  class StartUp
    {
      public  static void Main(string[] args)
        {
           
            const string END_COMMAND = "END";

            List<Person> people = new List<Person>();
            string command;
            while ((command=Console.ReadLine())!=END_COMMAND)
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                string town = cmdArgs[2];

                Person p = new Person(name, age, town);
                people.Add(p);
            }
            int n = int.Parse(Console.ReadLine());

            Person comparedPerson = people[n - 1];
            int samePersonCount = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(comparedPerson)==0)
                {
                    samePersonCount++;
                }
            }
            if (samePersonCount==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notSamePersonCount = people.Count - samePersonCount;
                Console.WriteLine($"{samePersonCount} " +
                    $"{notSamePersonCount} {people.Count}");
            }

        }
    }
}
