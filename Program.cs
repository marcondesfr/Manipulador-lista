using System;
using System.Collections.Generic;

namespace POO8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emplyeed> list = new List<Emplyeed>();
            int N;


            Console.Write("How many employees will be registered? ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {

                System.Console.WriteLine($"Employoee #{i + 1}");
                System.Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string Name = Console.ReadLine();
                System.Console.Write("Wage: ");
                double Wage = double.Parse(Console.ReadLine());
                System.Console.WriteLine();

                list.Add(new Emplyeed(Id, Name, Wage));
            }
            System.Console.Write("Enter the emplyoee id that will have salary increases: ");
            int searchId = int.Parse(Console.ReadLine());

            Emplyeed emp = list.Find(x => x.Id == searchId);
            if ( emp != null) {
                System.Console.Write("Porcente: ");
                double porcente = double.Parse(Console.ReadLine());
                emp.AddMoney(porcente);
            } else {
                System.Console.WriteLine("Sorry. This is not a corrent value.");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Updates employees dados.");

            foreach (Emplyeed item in list) {
                System.Console.WriteLine(item);
            }
        }
    }
}
