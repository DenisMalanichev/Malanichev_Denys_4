using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal class University
    {
        private List<APerson> students;
        public University(List<APerson> students)
        {
            this.students = students;
        }
        public void SortStudents()
        {
            int stud = 0, studAbsentia = 0, studContract = 0, studBudget = 0;
            foreach(APerson person in students)
            {
                String t = person.GetType().Name;
                switch (t)
                {
                    case "Student":
                        stud++;
                        break;
                    case "StudentInAbsentia":
                        studAbsentia++;
                        break;
                    case "StudentContract":
                        studContract++;
                        break;
                    case "StudentBudget":
                        studBudget++;
                        break;
                }
               
            } 
                Console.WriteLine("Studying in universuty:");
                Console.WriteLine("Students - " + stud);
                Console.WriteLine("StudentsInAbsentia - " + studAbsentia);
                Console.WriteLine("StudentsContract - " + studContract);
                Console.WriteLine("StudentsBudget - " + studBudget);
        }
    }
}
