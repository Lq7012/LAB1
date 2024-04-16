using System;

namespace Lab_1
{
    internal class Program
    {
        public static void Main()
        {
            // Виконувальний файл
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("1 - Собака, 2 - Тварина, 3 - Кіт, 4 - Своя тварина: ");
            string choice = Console.ReadLine();
            if (choice == "1") 
            {
                var dog = new Dog();
                dog.Name();
                dog.Age();
                dog.PerformAction();
                dog.Results();
            }
            else if (choice == "2") 
            {
                var animal = new Animal();
                animal.Name();
                animal.Age();
                animal.PerformAction();
                animal.Results();
            }
            else if (choice == "3") 
            {
                var cat = new Cat();
                cat.Name();
                cat.Age();
                cat.PerformAction();
                cat.Results();
            }
            else if (choice == "4") 
            {
                // Введіть код для вашого класу тут
                Console.WriteLine("Реалізація для своєї тварини ще не визначена");
            }
            else
            {
                Console.WriteLine("Число введено неправильно");
            }
        }
    }
}
