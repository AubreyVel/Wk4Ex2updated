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
            double finalExam = 0;

            //getting assignment grade average
            Console.WriteLine("Getting Assignmnet Grade average.");
            assignments = AssignmentsGrade();
            Console.WriteLine("Assignment grade average is: " + assignments);

            //getting Midterm grade azverage
            Console.WriteLine("Getting Midterm Grade average.");
            midterms = MidtermsGrade();
            Console.WriteLine("Midterm grade average is: " + midterms);

            //getting final exam average
            Console.WriteLine("Getting Final Exam Grade average.");
            finalExam = FinalExamsGrade();
            Console.WriteLine("Final Exam grade average is: " + finalExam);

            //calculating final grade
            Console.WriteLine("Getting Final Grade average.");
            Console.WriteLine("Final grade average is: " + CalculateFinalGrade(assignments, midterms, finalExam));


            Console.ReadLine();

        }

        public static double AssignmentsGrade()
        {
            
            List<double> assignments = new List<double>(); //using list top store grade values, will use .length to average grades later
            //declaring values
            string addAssignment; 
            double grade;
            double total = 0;
            double average;
            //using loop to repeatedly add values to List
            while (true)
            {
                //asking user if they want to input more grades
                Console.WriteLine("Add assignment grade? Y for yes, N for no.");
                addAssignment = Console.ReadLine();

                //if user inputs Y, add grades
                if (addAssignment == "Y")
                {
                    Console.WriteLine("Enter your grade for the assignment:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    assignments.Add(grade);

                }
                //user inputs N to start average calculation
                else
                {

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        total += assignments[i]; 
                    }

                    average = total / assignments.Count;


                    Console.WriteLine("Calculating assignments grade.");
                    return average;
                }
            }
        }




        public static double MidtermsGrade()
        {
            List<double> midterm = new List<double>(); //using list top store grade values, will use .length to average grades later
            //declaring values
            string addMidterm;
            double grade;
            double total = 0;
            double average;
            //using loop to repeatedly add values to List
            while (true)
            {
                //asking user if they want to input more grades
                Console.WriteLine("Add midterm grade? Y for yes, N for no.");
                addMidterm = Console.ReadLine();

                //if user inputs Y, add grades
                if (addMidterm == "Y")
                {
                    Console.WriteLine("Enter your grade for the midterm:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    midterm.Add(grade);

                }
                //user inputs N to start average calculation
                else
                {
                    //going through every value and adding it to total
                    for (int i = 0; i < midterm.Count; i++)
                    {
                        total += midterm[i];
                    }
                    //averaging out the grade
                    average = total / midterm.Count;

                    //returning average value
                    Console.WriteLine("Calculating midterm grade.");
                    return average;
                }
            }
        }
        public static double FinalExamsGrade()
        {
            List<double> finalExam = new List<double>(); //using list top store grade values, will use .length to average grades later
            //declaring values
            string addFinalExam;
            double grade;
            double total = 0;
            double average;
            //using loop to repeatedly add values to List
            while (true)
            {
                //asking user if they want to input more grades
                Console.WriteLine("Add final exam grade? Y for yes, N for no.");
                addFinalExam = Console.ReadLine();

                //if user inputs Y, add grades
                if (addFinalExam == "Y")
                {
                    Console.WriteLine("Enter your grade for the final exam:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    finalExam.Add(grade);

                }
                //user inputs N to start average calculation
                else
                {
                    //going through every value and adding it to total
                    for (int i = 0; i < finalExam.Count; i++)
                    {
                        total += finalExam[i];
                    }
                    //averaging out the grade
                    average = total / finalExam.Count;

                    //returning average value
                    Console.WriteLine("Calculating Final Exam grade.");
                    return average;
                }
            }
        }
        public static double CalculateFinalGrade(double assignments, double midterms, double finals)
        {
            //Calculating final grade
            double finalAveragedGrade = (assignments*.4) + (midterms * .3) + (finals*.3);
            //returniong calculated grade
            return finalAveragedGrade;
        }
    }
}