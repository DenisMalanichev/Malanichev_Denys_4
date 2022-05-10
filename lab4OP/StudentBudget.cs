using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal class StudentBudget : APerson
    {
        public StudentBudget(int cource) : base(cource)
        {
        }

        public override int PairsCount()
        {
            return new Random().Next(100, 500);
        }

        public override DateTime SesionStartDate()
        {
            return DateTime.Now;
        }
        public void SayBudget()
        {
            Console.WriteLine("I am budget student!");
        }
    }
}
