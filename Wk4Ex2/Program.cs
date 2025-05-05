using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations

            
            double assignments = 0;
            double midterms = 0;
            double finals = 0;

            //getting assignment grade average
            Console.WriteLine("Getting Assignmnet Grade average.");
            Console.WriteLine("Assignment grade average is: " + AssignmentsGrade());

            //getting Midterm grade azverage
            Console.WriteLine("Getting Midterm Grade average.");
            Console.WriteLine("Midterm grade average is: " + MidtermsGrade());

            //getting final exam average
            Console.WriteLine("Getting Final Exam Grade average.");
            Console.WriteLine("Final Exam grade average is: " + FinalExamsGrade());

            //calculating final grade
            Console.WriteLine("Getting Final Grade average.");
            Console.WriteLine("Final grade average is: " + FinalExamsGrade());


        }

        public static double AssignmentsGrade()
        {
            
            List<double> assignments = new List<double>(); //using list top store grade values, will use .length to average grades later
            string addAssignment = ""; 
            double grade;
            double total;
            double average;
            while (true)
            {
                Console.WriteLine("Add assignment grade? Y for yes, anything else for no.");
                addAssignment = Console.ReadLine();
                if (addAssignment == "Y")
                {
                    Console.WriteLine("Enter your grade for the assignment:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    assignments.Add(grade);

                }

                else
                {
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        total += assignments[i]; 
                    }

                    average = total / assignments.Count;


                    Console.WriteLine("Calculating assignments grade done.");
                    return average;
                }
            }
        }




        public static double MidtermsGrade()
        {

        }
        public static double FinalExamsGrade()
        {

        }
        public static double CalculateFinalGrade(double assignments, double midterms, double finals)
        {

        }
    }
}