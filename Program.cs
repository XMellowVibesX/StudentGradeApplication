// See https://aka.ms/new-console-template for more information
using System;

namespace StudentGradeApplication
{
    class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            /*
             Most--if not all--code is reused from my 02 Lab 2 
            since it runs on the same logic, just with a few tweaks
             */

            // Declaring/initializing
            string[] subjects = { "English", "Math", "Science", "Filipino", "History" };
            double[] grades = new double[subjects.Length];
            double sum = 0;
            int i1 = 0;
            int i2 = 0;


            // Student name
            Console.WriteLine("=======================================");
            Console.Write("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("=======================================");

            // for-each loops to go through each slot in the arrays
            foreach (string x in subjects)
            {
                Console.Write(x+": ");
                while (i1 < subjects.Length)
                {
                    grades[i1] = Convert.ToDouble(Console.ReadLine());
                    i1++;
                    break;
                }
            }

            foreach (double y in grades)
            {
                sum += grades[i2];
                i2++;
            }

            // calculating average
            double average = (sum / grades.Length);

            Console.WriteLine("=======================================");

            string result = average >= 75.00 ? "The student got a passing score." : "The student didn't get a passing score.";
            Console.WriteLine(result+ "\nThe general average of " + userName + " is " + average);
        }
    }
}