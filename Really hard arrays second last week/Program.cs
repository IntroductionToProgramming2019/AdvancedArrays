/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Advanced Arrays
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Really_hard_arrays_second_last_week
{
    class Program
    {
        static string[] names = { "Tom", "Mark", "Jane", "Eileen", "Sebastian" };
        static int[] marks = new int[5];
        static string[] highest_mark = new string[0];
        static void Main(string[] args)
        {
            Addmarks();
            PrintMarks();
            DisplayAverage();
            int Average = DisplayAverage();
            Console.WriteLine("The average is {0}", Average);
            string name = highestScoreName();
            Console.WriteLine("The person with the highest score is {0}", name);
            int numPasses = Passes();
            Console.WriteLine("{0} students passed", numPasses);
        }
        static void Addmarks()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Please enter the mark for {0}:", names[i]);
                marks[i] = int.Parse(Console.ReadLine());
                if ((marks[i] > 100) || (marks[i] < 0))
                {
                    Console.WriteLine("Invalid input. Please enter a valid mark for {0} : ", names[i]);
                    marks[i] = int.Parse(Console.ReadLine());

                }

            }

        }
        static void PrintMarks()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("{0}'s marks was {1}", names[i], marks[i]);
            }
        }
        static int DisplayAverage()
        {
            int average = 0;
            int total = 0;
            for (int i = 0; i < names.Length; i++)
            {
                total = total + (marks[i]);
            }
            average = total / (names.Length);
            return average;
        }
        static string highestScoreName()
        {
            int highest_mark_index = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > marks[highest_mark_index])
                {
                    highest_mark_index = i;
                }
            }
            return names[highest_mark_index];
        }
        static int Passes()
        {
            int passes = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (marks[i]>=40)
                {
                    passes = passes + 1;
                }
            }
            return passes;
        }
    }
}



