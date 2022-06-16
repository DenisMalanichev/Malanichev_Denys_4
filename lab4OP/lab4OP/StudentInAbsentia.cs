using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal class StudentInAbsentia : APerson
    {
        public StudentInAbsentia(int cource) : base(cource)
        {
        }

        public override int PairsCount()
        {
            return 0;
        }

        public override DateTime SesionStartDate()
        {
            return DateTime.Now;
        }
        public int HoursForSelfstuding()
        {
            return new Random().Next(100, 300);
        }
    }
}
