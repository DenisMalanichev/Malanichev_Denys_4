using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4OP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(1);
            var studentBudget = new StudentBudget(3);
            var studentContract = new StudentContract(2);
            var studentAbsentia = new StudentInAbsentia(4);
            List<APerson> people = new List<APerson>();
            people.Add(student);
            people.Add(studentBudget);
            people.Add(studentContract);
            people.Add(studentAbsentia);
            foreach(APerson stud in people)
            {
                Console.WriteLine(stud.ToString());
                Console.WriteLine("This stydent is on " + stud.Cource + " cource");
                Console.WriteLine("Session starts " + stud.SesionStartDate());
                Console.WriteLine("Is scholatship - " + stud.IsScholarship());
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
    }
}
