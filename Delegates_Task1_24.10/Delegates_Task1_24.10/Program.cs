using Delegates_Task1_24._10.Models;
using System;

namespace Delegates_Task1_24._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person {Name = "Kamil", Surname="Sadigov", Age=23},
                new Person {Name = "Rashad" , Surname="Rufullyev",Age=19 },
                new Person {Name = "Alpay", Surname="Abdullayev",Age=20},
                new Person {Name = "Ehmed",Surname="Osmanov",Age=24},
                new Person {Name = "Murad" ,Surname="Qenberov",Age=22},
            };

            Console.WriteLine("Adi daxil edin");
            string name = Console.ReadLine().ToLower();
            List<Person> checkname = people.FindAll(x => x.Name.ToLower() == name);
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }
            



            List<Person> checksurname = people.FindAll(x => x.Surname.EndsWith("ov") || x.Surname.EndsWith("ova"));
            Console.WriteLine("Soyadı 'ov' və 'ova' ile bitenler:");
            foreach(Person person in checksurname)
            {
                Console.WriteLine($"{person.Name} {person.Surname }");
            }
            


            List<Person> checkage = people.FindAll(x => x.Age > 20);
            Console.WriteLine("Yashi 20-den boyuk olanlar:");
            foreach (Person person in checkage)
            {
                Console.WriteLine($"{person.Name}{person.Surname} {person.Age}");
            }
           

        }
    }
}