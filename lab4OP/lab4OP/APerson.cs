using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal abstract class APerson
    {
        public int Cource { get; }
        public APerson(int cource)
        {
            Cource = cource;
        }
        public abstract DateTime SesionStartDate();
        public abstract int PairsCount();
        public bool IsScholarship()
        {
            return Cource > 2;
        }
        public int StudingCost()
        {
            return (4 - Cource) * 28500;
        }
        
    }
}
