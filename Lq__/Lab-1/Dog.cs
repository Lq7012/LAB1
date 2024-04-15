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
        // Клас людини
        public string VarName { get; set; }
        public int VarAge { get; set; }
        public string VarAction { get; set; }
        public void Name()
        {
            Console.Write("Введіть ім'я собаки: ");
            this.VarName = Console.ReadLine();
        }
        public void Age()
        {
            Console.Write("Введіть вік собаки: ");
            this.VarAge = Convert.ToInt32(Console.ReadLine());
        }
        public void Action()
        {
            Console.Write("Дію собаки: ");
            this.VarAction = Console.ReadLine();
        }
        public void Results() 
        {
            Console.Clear();
            Console.WriteLine("ім'я собаки: " + VarName + "\nвік собаки: " + VarAge + "\nДія собаки: " + VarAction);
            Console.WriteLine("Лікування... ");
            Thread.Sleep(2000);
            Console.WriteLine("дія собки " + '"' + VarAction + '"' + ": " + "завершена.");
            Console.ReadLine();
        }
    }
}
