using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Program
    {
        
        public static void Main()
        {
            // Виконувальний файл
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("1 - Собака, 2 - Тварина, 3 - Кіт, 4 - Своя тварина: ");
            string animalChoice = Console.ReadLine();
            if (animalChoice == "1") 
            {
                var dog = new CustomAnimal();
                dog.Name();
                dog.Age();
                dog.PerformAction();
                dog.ShowResults();
            }
            else if (animalChoice == "2") 
            {
                var animal = new CustomAnimal();
                animal.Name();
                animal.Age();
                animal.PerformAction();
                animal.ShowResults();
            }
            else if (animalChoice == "3") 
            {
                var cat = new CustomAnimal();
                cat.Name();
                cat.Age();
                cat.PerformAction();
                cat.ShowResults();
            }
            else if (animalChoice == "4") 
            {
                var customAnimal = new CustomAnimal();
                customAnimal.KindOfAnimals();
                customAnimal.Name();
                customAnimal.Age();
                customAnimal.PerformAction();
                customAnimal.ShowResults();
            }
            else
            {
                Console.WriteLine("Число введено неправильно");
            }
            
            var animal = new CustomAnimal();
            var cat = new CustomAnimal();
            var customAnimal = new CustomAnimal(); 
        }
    }
}
