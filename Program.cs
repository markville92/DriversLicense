using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers_count = 0;
            int incorrectAnswers_count = 0;
            


            ArrayList str_gradesList = new ArrayList();
            str_gradesList.AddRange(new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" });


            ArrayList str_anotherList = new ArrayList();          

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter the student's answer of Question {0}:", i + 1);
                str_anotherList.Add(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                if (Object.Equals(str_gradesList[i], str_anotherList[i]))
                {

                    correctAnswers_count += 1;                    
                    
                }

                if (!Object.Equals(str_gradesList[i], str_anotherList[i]))
                {
                    incorrectAnswers_count += 1;
                    
                    Console.WriteLine("Question {0} was answered incorrectly.", i + 1);             

                }
            }

            

            if (correctAnswers_count >= 15)
            {
                Console.WriteLine("The student passed!");
            }
            else
            {
                Console.WriteLine("Student did not pass.");
            }



            Console.WriteLine("Student incorrectly answered {0} of 20!", incorrectAnswers_count);
            Console.WriteLine("Student answered {0} of 20 right. ", correctAnswers_count);
            


            Console.WriteLine();
        }
    }
}
