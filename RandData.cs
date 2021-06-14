using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using Bogus.DataSets;

namespace MoreLinqExamples
{
    class RandData
    {
        public static List<Person> GetRandomPeople(string locale = "az")
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 100; i++)
            {
                Name name = new Name(locale);

                people.Add(new Person()
                {
                    Id = i + 1,
                    Name = name.FirstName(),
                    Surname = name.LastName(),
                    Age = new Randomizer().Number(18, 100)
                });
            }

            return people;
        }

        public static List<Person> GetStaticPeople()
        {
            return new List<Person>()
            {
                new Person() { Id = 1, Name = "Farid", Surname = "Huseynli", Age = 26},
                new Person() { Id = 2, Name = "Kazim", Surname = "Abdullayev", Age = 18},
                new Person() { Id = 3, Name = "Hesen", Surname = "Hesenov", Age = 16},
                new Person() { Id = 4, Name = "Fariq", Surname = "Nesirov", Age = 30},
                new Person() { Id = 5, Name = "Nizami", Surname = "Ibadov", Age = 48},
                new Person() { Id = 6, Name = "Farid", Surname = "Abasov", Age = 15},
                new Person() { Id = 7, Name = "Abas", Surname = "Abasov", Age = 55},
                new Person() { Id = 8, Name = "Nesimi", Surname = "Huseynov", Age = 70},
                new Person() { Id = 9, Name = "Cingiz", Surname = "Musayev", Age = 77},
                new Person() { Id = 10, Name = "Eli", Surname = "Kazimov", Age = 36},
            };
        }
    }
}
