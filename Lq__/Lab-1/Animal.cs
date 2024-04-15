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
            this.VarName = Console.ReadLine();
        }
        public void Age()
        {
            Console.Write("Введіть вік тварини: ");
            this.VarAge = Console.ReadLine();
        }
        public void Action()
        {
            Console.Write("Введіть дію тварни: ");
            this.VarAction = Console.ReadLine();
        }
        public void Results()
        {
            Console.Clear();
            Console.WriteLine("Ім'я тварини: " + VarName + "\nВік тварини: " + VarAge + "\nдія тварни: " + VarAction);
            Thread.Sleep(2000);
            Console.WriteLine("дія тварини " + '"' + VarAction + '"' + ": " + "завершена.");
            Console.ReadLine();
        }
    }
}
