using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba8_Task4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ с массивом

            Console.WriteLine("Вариант 1 - Вычислить сумму всех чисел в диапазоне от 10 до 20");
            int[] numbers = new int[30];
            Random random = new Random();
            for(int i =0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-20, 25);
            }
            foreach(int numb in numbers)
            {
                Console.Write(numb+ "\t");
            }
            int sum = (from k in numbers where (k >= 10 && k <= 20) select k).Sum();
            Console.WriteLine(" sum = " + sum);

            sum = numbers.Where(k => k >= 10 && k <= 20).Sum();
            Console.WriteLine("sum1 = " + sum);

            //LINQ с коллекцией

            Company microsoft = new Company { name = "Microsoft", year = 1975 };
            Company oracle = new Company { name = "Oracle", year = 1977 };
            Company xerox = new Company { name = "Xerox", year = 1996 };
            Company apple = new Company { name = "Apple", year = 1976 };
            List<Company> companies = new List<Company> { microsoft, oracle, xerox, apple };
            List<Person> list = new List<Person> 
            {
                new Person
                {
                    name = "Lukas",
                    year = 1972,
                    company = new Company
                    {
                        name = "Microsoft1",
                        year = 1975
                    }
                },

                new Person
                {
                    name = "Tom",
                    year = 1995,
                    company = oracle
                },

                new Person
                {
                    name = "Kira",
                    year = 1987, 
                    company = apple
                },
                new Person
                {
                    name = "Bob",
                    year = 1989,
                    company = xerox
                }
            };

            Console.WriteLine("Вариант 1 - Список сотрудников, которые старше их компаний. Включает имя, возраст, Company");
            var select1 = from person in list
                          where person.year < person.company.year
                          select new
                          {
                              Name = person.name,
                              PersonYear = person.year,
                              Com = person.company.name,
                              ComYear = person.company.year
                          };
            foreach(var k in select1)
            {
                Console.WriteLine(k.Name + " " + k.PersonYear + " " + k.Com + " " + k.ComYear);
            }
            Console.WriteLine("_--------------------------------------------------_");
            var select2 = list.Where(person => person.year < person.company.year)
                .Select(person => new
                {
                    Name = person.name,
                    PersonYear = person.year,
                    Com = person.company.name,
                    ComYear = person.company.year
                });
            foreach (var k in select2)
            {
                Console.WriteLine(k.Name + " " + k.PersonYear + " " + k.Com + " " + k.ComYear);
            }

        }
    }
}
