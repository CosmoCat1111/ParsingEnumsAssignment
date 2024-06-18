using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                try
                {
                    Console.WriteLine("Enter the current day of the week:  ");
                    String personinput = Console.ReadLine();

                    DaysOfWeek person1 = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), personinput);

                    Console.WriteLine("Today is " + person1);
                    Console.ReadLine();
                    isvalid = true;

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Whoops, Please enter a day of the week.");
                }
            }
            Console.ReadLine();
        }
    }
}
