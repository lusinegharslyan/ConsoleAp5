using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{


    internal class Program
    {
        public static void AddingPerson(List<string> data, string name, string surname, string age)
        {

            data.Add(name + " " + surname + " " + " " + age);
            // Console.WriteLine(data[0]);
        }

        public static void RemoveItem(List<string> data, int index)
        {
            data.RemoveAt(index);

        }

        public static void GetAllItems(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        public static void PrintingIndex(List<string> data, int index)
        {
            Console.WriteLine(data[index]);
        }

        public static void GetNameAndSurName(List<string> data, int index)
        {
            string[] info = data[index].Split(' ');
            Console.WriteLine($"Name is {info[0]}");
            Console.WriteLine($"SurName is {info[1]}");
        }

        public static void CreatingArrayOfCars(string[] cars, int length)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Type mark of car: ");
                string mark = Console.ReadLine();
                Console.WriteLine("Type date of car: ");
                string date = Console.ReadLine();
                Console.WriteLine("Type price of car: ");
                string price = Console.ReadLine();
                cars[i] = mark + " " + date + " " + price;

            }
        }


        public static void GetAllItems(string[] cars)
        {
            Console.WriteLine("Elements in Cars array are:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i]);
            }
        }

        public static void GetSpecificItem(string[] cars, int index)
        {
            Console.WriteLine($"Elemnet in {index} index is {cars[index]}");
        }

        public static string[] RemoveIndex(string[] cars, int index)
        {
            string[] newArray = new string[cars.Length - 1];
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                newArray[i] = cars[i];
            }
            return newArray;
        }

        //Data with dogs
        public static string[] AddingData(string[] dogs)
        {
            Console.Write("Type name: ");
            string name = Console.ReadLine();
            Console.Write("Type age: ");
            string age = Console.ReadLine();
            Console.Write("Type price: ");
            string price = Console.ReadLine();
            string[] newDogs = new string[dogs.Length + 1];
            newDogs[newDogs.Length - 1] = name + " " + age + " " + price;
            return newDogs;
        }

        public static void PrintingAllItems(string[] dogs)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                string[] item = dogs[i].Split(' ');
                Console.WriteLine($"Item {i + 1}:");
                Console.WriteLine($"Name: {item[0]}");
                Console.WriteLine($"Age: {item[1]}");
                Console.WriteLine($"Price: {item[2]}");
            }
        }

        public static void PrintingSpecItem(string[] dogs)
        {
            Console.WriteLine("Type index: ");
            int index = int.Parse(Console.ReadLine());
            string[] item = dogs[index].Split(' ');
            Console.WriteLine($"Item {index}:");
            Console.WriteLine($"Name: {item[0]}");
            Console.WriteLine($"Age: {item[1]}");
            Console.WriteLine($"Price: {item[2]}");

        }

        public static string[] RemovingItem(string[] dogs)
        {
            Console.WriteLine("Type index to remove: ");
            int index = int.Parse(Console.ReadLine());
            string[] newDogs = new string[dogs.Length - 1];
            for (int i = 0; i < newDogs.Length; i++)
            {
                if (i >= index)
                {
                    newDogs[i] = dogs[i + 1];
                }
                newDogs[i] = dogs[i];
            }

            return newDogs;
        }

        //public static void DoingFunction(int answer, string[] dogs)
        //{
        //    switch (answer)
        //    {
        //        case 1:
        //            AddingData(dogs);
        //            break;
        //        case 2:
        //            PrintingAllItems(dogs);
        //            break;
        //        case 3:
        //            PrintingSpecItem(dogs);
        //            break;
        //        case 4:
        //            RemovingItem(dogs);
        //            break;
        //    }
        //}
        static void Main(string[] args)
        {
            //List<string> data = new List<string>();
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.Write("Type name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Type surname: ");
            //    string surname = Console.ReadLine();
            //    Console.Write("Type age: ");
            //    string age = Console.ReadLine();


            //    AddingPerson(data, name, surname, age);
            //}
            //Console.Write("Type an index to remove: ");
            //int index = int.Parse(Console.ReadLine());
            //RemoveItem(data, index);
            //Console.Write("Type an index to print: ");
            //int index1 = int.Parse(Console.ReadLine());
            //PrintingIndex(data, index1);


            //Console.Write("Type an index to get name and surname: ");
            //int index2 = int.Parse(Console.ReadLine());

            //GetNameAndSurName(data, index2);
            //GetAllItems(data);
            //Console.WriteLine("Type the length of cars array: ");
            //int length = int.Parse(Console.ReadLine());

            //string[] cars = new string[length];
            //CreatingArrayOfCars(cars, length);



            //GetAllItems(cars);



            //Console.Write("Type index to print");
            //int index = int.Parse(Console.ReadLine());
            //GetSpecificItem(cars, index);

            //Data with dogs

            //Adding data

            //do
            //{
            //    string[] dogs = new string[1];
            //    Console.WriteLine("Choose the command by number:");
            //    Console.WriteLine("1-Add data");
            //    Console.WriteLine("2-Print all items");
            //    Console.WriteLine("3-Print specfic item");
            //    Console.WriteLine("4-Remove item");
            //    int answer = int.Parse(Console.ReadLine());
            //    DoingFunction(answer, dogs);
            //} while (true);

            do
            {
                string[] dogs = new string[1];
                Console.WriteLine("Choose the command by number:");
                Console.WriteLine("1-Add data");
                Console.WriteLine("2-Print all items");
                Console.WriteLine("3-Print specfic item");
                Console.WriteLine("4-Remove item");
                int answer = int.Parse(Console.ReadLine());
            } 
            while (true);

            Console.WriteLine("Hello");

            Console.ReadLine();
        }
    }
}
