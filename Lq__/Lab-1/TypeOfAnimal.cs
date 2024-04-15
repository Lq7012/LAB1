using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class TypeOfAnimal : Animal
    {
        // Наслідний клас
        public string KindOfAnimal {  get; set; }

        public void KindOfAnimals()
        {
            Console.Write("Введіть вид тварини: ");
            this.KindOfAnimal = Console.ReadLine();
        }
        public void Results()
        {
            Console.Clear();
            Console.WriteLine("Вид тварини: " + KindOfAnimal +  "\nІм'я тварини: " + VarName + "\nВік тварини: " + VarAge + "\nДія тварини: " + VarAction);
            Console.WriteLine("Дія... ");
            Thread.Sleep(2000);
            Console.WriteLine("Дія тварини " + '"' + VarAction + '"' + ": " + "завершена.");
            Console.ReadLine();
        }
    }
}
