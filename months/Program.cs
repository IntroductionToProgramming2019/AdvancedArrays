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

namespace months
{
    class Program
    {
        static string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a month number: ");
            int monthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ",months[monthNumber-1]);
        }
    }
}
