using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Trevor";

            string sweetness = "Not Brett";

            string lastName = "Griest";

            string instructorName1 = "Ernest";

            string instructorName2 = "Jen";

            int programmingTime = 1;

            int age = 38;

            int puttingOnSomeYears = 40;

            int oldAge = age + puttingOnSomeYears;

            int instructorAge1 = 33;

            int instructorAge2 = 35;

            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine("I am " + age + " years old");

            Console.WriteLine("I'm really glad I'm not " + oldAge + " years old!");

            Console.WriteLine("I have been programming for " + programmingTime + " day!");

            Console.WriteLine("My instructor today is " + instructorName1 + ", and he is " + instructorAge1 + " years old.");

            Console.WriteLine("My instructor yesterday was " + instructorName2 + " and she looks to be " + instructorAge2 + " years old.");

            Console.WriteLine("Who is the sweetness? " + sweetness + "!");

        }
    }
}
