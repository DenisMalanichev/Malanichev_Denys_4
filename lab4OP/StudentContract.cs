using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal class StudentContract : APerson
    {
        public StudentContract(int cource) : base(cource)
        {
        }

        public override int PairsCount()
        {
            return new Random().Next(100, 400);
        }

        public override DateTime SesionStartDate()
        {
            return DateTime.Now;
        }
        public DateTime TimeToPAy()
        {
            DateTime timeToPay = new DateTime(2022, 5, 1);
            return timeToPay;
        }
    }
}
