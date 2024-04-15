using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Cat : IPatient
    {
        // Клас кота
        public string VarName { get; set; }
        public string VarAge { get; set; }
        public string VarAction { get; set; }
        public void Name()
        {
            Console.Write("Введіть ім'я кота: ");
            this.VarName = Console.ReadLine();
        }
        public void Age()
        {
            Console.Write("Введіть вік кота: ");
            this.VarAge = Console.ReadLine();
        }
        public void Action()
        {
            Console.Write("Введіть дію кота: ");
            this.VarAction = Console.ReadLine();
        }
        public void Results()
        {
            Console.Clear();
            Console.WriteLine("Ім'я кота: " + VarName + "\nВік кота: " + VarAge + "\nДія кота: " + VarAction);
            Thread.Sleep(2000);
            Console.WriteLine("Дія кота " + '"' + VarAction + '"' + ": " + "завершена.");
            Console.ReadLine();
        }
    }
}
