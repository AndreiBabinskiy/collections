using System;
using System.Collections;
using System.Collections.Generic;

namespace Laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //List list = new List();

            arrayList.Add(new Pet("жираф", 100));
            arrayList.Add(new Bird("сорока", 5));
            arrayList.Add(new Pet("кролик", 10));
            //arrayList.Add(new Duck("утка", 8));
            arrayList.Add(new Pet("свинья", 25));
            //arrayList.Add(new Duck("утка", 6));
            arrayList.Add(new Pet("корова", 50));
            arrayList.Add(new Bird("воробей", 9));
            arrayList.Add(new Pet("хорёк", 3));
            arrayList.Add(new Pet("лошадь", 39));


            while (true)
            {
                Console.WriteLine("  Главное меню   ");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 – просмотр коллекции");
                Console.WriteLine("2 – добавление элемента (данные вводим с клавиатуры)");
                Console.WriteLine("3 – добавление элемента по указанному индексу (индекс и данные вводим с клавиатуры)");
                Console.WriteLine("4 – нахождение элемента с начала коллекции (переопределить метод Equals или оператор == для вашего класса – сравнение только по полю name) (данные для поиска по полю name вводим с клавиатуры, вы должны иметь минимум 2 объекта в коллекции с одинаковыми именами)");
                Console.WriteLine("5 – нахождение элемента с конца коллекции (данные для поиска по полю name вводим с клавиатуры, вы должны иметь минимум 2 объекта в коллекции с одинаковыми именами)");
                Console.WriteLine("6 – удаление элемента по индексу (индекс вводим с клавиатуры)");
                Console.WriteLine("7 – удаление элемента по значению (данные для поиска по полю name вводим с клавиатуры)");
                Console.WriteLine("8 – реверс коллекции");
                Console.WriteLine("9 – сортировка");
                Console.WriteLine("10 – выполнение методов всех объектов, поддерживающих IFlying");
                Console.WriteLine("0 – выход");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1: method1(arrayList); break;
                    case 2: method2(arrayList); break;
                    case 3: method3(arrayList); break;
                    case 4: method4(arrayList); break;
                    case 5: method5(arrayList); break;
                    case 6: method6(arrayList); break;
                    case 7: method7(arrayList); break;
                    case 8: method8(arrayList); break;
                    case 9: method9(arrayList); break;
                    case 10: method10(arrayList); break;

                    default: return;
                }         
            }

            Pet[] pets = new Pet[]
            {
                new Pet(),
                new Pet("журавль"),
                null,
                new Pet("скворчёк", 40),
                null,
                null
            };
            Console.WriteLine(method(pets));

            object[] p = new object[] { new Pet(), 4, null, 2.6, null };
            Console.WriteLine(p);
        }

        static int method<T>(T[] pets)
        {
            return 0;
        }
        static void method1(ArrayList list)
        {
            foreach(object obj in list)
            {
                Console.WriteLine((obj as Pet)?.ToString());
            }
            Console.ReadKey();
        }

        static void method2(ArrayList list)
        {
            Console.WriteLine(" Добавляем Pet или Bird (1 или 2) ?");
            String end = Console.ReadLine();
            int n;
            if(!Int32.TryParse(end, out n) || n < 1 || n > 2)
            {
                return;
            }
            Console.Write("name: ");
            string nameAnimal = Console.ReadLine();
            Console.Write("age: ");
            end = Console.ReadLine();
            int age;
            Int32.TryParse(end, out age);
            switch(n)
            {
                case 1:
                    list.Add(new Pet(nameAnimal, age));
                    break;
                case 2:
                    list.Add(new Bird(nameAnimal, age));
                    break;
            }
        }

        static void method3(ArrayList list)
        {
            Console.WriteLine("индекс: ");
            String endResult = Console.ReadLine();
            int index;
            if (!Int32.TryParse(endResult, out index) || index < 0 || index > list.Count)
            {
                Console.WriteLine("неверный индекс");
                return;
            }
            Console.WriteLine(" Добавляем Pet или Bird (1 или 2) ?");
            endResult = Console.ReadLine();
            int n;
            if (!Int32.TryParse(endResult, out n) || n < 1 || n > 2)
            {
                return;
            }
            Console.Write("\nname: ");
            string nameAnimal = Console.ReadLine();
            Console.Write("age: ");
            endResult = Console.ReadLine();
            int age;
            Int32.TryParse(endResult, out age);
            switch (n)
            {
                case 1:
                    list.Insert(index, new Pet(nameAnimal, age));
                    break;
                case 2:
                    list.Insert(index, new Bird(nameAnimal, age));
                    break;
            }

        }

        static void method4(ArrayList list)
        {
            Console.WriteLine("name: ");
            String name = Console.ReadLine();
            Pet pet = new Pet(name);
            int index = list.IndexOf(pet);
            Console.WriteLine(index > -1 ? $"\nИндекс = {index}; {list[index]}": "Элемент не найден");
        }

        static void method5(ArrayList list) //индекс начинается с нуля
        {
            Console.WriteLine("name: ");
            String name = Console.ReadLine();
            Pet pet = new Pet(name);
            int index = list.LastIndexOf(pet);
            Console.WriteLine(index > -1 ? $"\nИндекс = {index}; {list[index]}" : "Элемент не найден");
        }

        static void method6(ArrayList list)
        {
            Console.WriteLine("индекс: ");
            String endResult = Console.ReadLine();
            int index;
            if (!Int32.TryParse(endResult, out index) || index < 0 || index > list.Count)
            {
                Console.WriteLine("неверный индекс");
                return;
            }
            list.RemoveAt(index);
            Console.WriteLine("Элемент успешно удалён");
        }

        static void method7(ArrayList list)
        {
            Console.WriteLine("name: ");
            String name = Console.ReadLine();
            Pet pet = new Pet(name);
            list.Remove(pet);
            Console.WriteLine("Элемент успешно удалён");
        }

        static void method8(ArrayList list)
        {
            list.Reverse();

            foreach (object obj in list)
            {
                Console.WriteLine((obj as Pet)?.ToString());
            }
            Console.ReadKey();
        }

        static void method9(ArrayList list)
        {
            list.Sort();

            foreach (object obj in list)
            {
                Console.WriteLine((obj as Pet)?.ToString());
            }
            Console.ReadKey();
        }

        static void method10(ArrayList list)
        {

            foreach (object obj in list)
            {
                if(obj is IFlying)
                {
                    Console.WriteLine((obj as Pet)?.ToString());
                }
                (obj as IFlying)?.Fly();  
            }
            Console.ReadKey();
        }
    }
}
