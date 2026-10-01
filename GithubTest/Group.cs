using System;
using System.Collections.Generic;
using System.Text;

namespace GithubTest
{
    internal class Group
    {
        public string Name { get; set; }
        private List<Person>? People { get; set; } = new();
        public void AddPerson(Person person)
        {
            People!.Add(person);
        }
        public void RemovePerson(Person person)
        {
            People!.Remove(person);
        }

        public void Print()
        {
            Console.WriteLine($"Name - {Name}");
            foreach (var p in People!)
            {
                Console.WriteLine(p);
            }
        }

    }
}
