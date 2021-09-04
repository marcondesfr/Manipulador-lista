using System;
namespace POO8
{
    public class Emplyeed
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Wage { get; set; }

        public void AddMoney(double porcents ) { 
            Wage += Wage / 100 * porcents;
        }

        public Emplyeed ( int id, string name, double wage) {
            Id = id;
            Name = name;
            Wage = wage;
        }
        public override string ToString() {
            return Name + ", " + Wage.ToString("F2") ;
        }

        
    }
}