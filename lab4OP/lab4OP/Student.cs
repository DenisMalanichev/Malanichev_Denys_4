using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal class Student : APerson
    {
        public Student(int cource) : base(cource)
        {
        }

        public override int PairsCount()
        {
            return new Random().Next(100, 300);
        }

        public override DateTime SesionStartDate()
        {
            return DateTime.Now;
        }
    }
}
