using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Animal : IPatient
    {
        // Клас тварини
        public string VarName { get; set; }
        public string VarAge { get; set; }
        public string VarAction { get; set; }

        public void Name()
        {
            Console.Write("Введіть ім'я тварини: ");
            VarName = Console.ReadLine();
        }

        public void Age()
        {
            Console.Write("Введіть вік тварини: ");
            VarAge = Console.ReadLine();
        }

        public void PerformAction()
        {
            Console.Write("Введіть дію тварини (їсть, спить, грається і т.д.): ");
            VarAction = Console.ReadLine();
        }

        public void Results()
        {
            Console.Clear();
            Console.WriteLine("Ім'я тварини: " + VarName + "\nВік тварини: " + VarAge + "\nДія тварини: " + VarAction);
            Thread.Sleep(2000);
            Console.WriteLine("Дія тварини " + '"' + VarAction + '"' + ": " + "завершена.");
            Console.ReadLine();
        }
    }
}
 
