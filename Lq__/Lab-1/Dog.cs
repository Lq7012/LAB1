using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Dog : IPatient
    {
        // Клас собаки
        public string VarName { get; set; }
        public int VarAge { get; set; }
        public string VarAction { get; set; }
        
        public void Name()
        {
            Console.Write("Введіть ім'я собаки: ");
            VarName = Console.ReadLine();
        }
        
        public void Age()
        {
            Console.Write("Введіть вік собаки: ");
            VarAge = Convert.ToInt32(Console.ReadLine());
        }
        
        public void PerformAction()
        {
            Console.Write("Дію собаки: ");
            VarAction = Console.ReadLine();
        }
        
        public void Results() 
        {
            Console.Clear();
            Console.WriteLine("Ім'я собаки: " + VarName + "\nВік собаки: " + VarAge + "\nДія собаки: " + VarAction);
            Console.WriteLine("Лікування... ");
            Thread.Sleep(2000);
            Console.WriteLine("Дія собаки " + '"' + VarAction + '"' + ": " + "завершена.");
            Console.ReadLine();
        }
    }
}
