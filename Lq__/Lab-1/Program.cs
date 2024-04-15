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
            string patient;
            patient = Console.ReadLine();
            if (patient == "1") 
            {
                var VarHuman = new Dog();
                VarHuman.Name();
                VarHuman.Age();
                VarHuman.Action();
                VarHuman.Results();
            }
            else if (patient == "2") 
            {
                var VarAnimal = new Animal();
                VarAnimal.Name();
                VarAnimal.Age();
                VarAnimal.Action();
                VarAnimal.Results();
            }
            else if (patient == "3") 
            {
                var VarCat = new Cat();
                VarCat.Name();
                VarCat.Age();
                VarCat.Action();
                VarCat.Results();
            }
            else if (patient == "4") 
            {
                var VarAnimal = new TypeOfAnimal();
                VarAnimal.KindOfAnimals();
                VarAnimal.Name();
                VarAnimal.Age();
                VarAnimal.Action();
                VarAnimal.Results();
            }
            else
            {
                Console.WriteLine("Число введено неправильно");
            }
            
            var Animal = new Animal();
            var Cat = new Cat();
            var TypeOfAnimal = new TypeOfAnimal(); 
        }
    }
}
