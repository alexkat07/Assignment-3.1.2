using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year");
            int userYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IfYearIsLeap(userYear));

           
        }

        static bool IfYearIsLeap(int year) 
        {
            if (0 < year && year <1000 && year % 4 == 0) 
            {
                return true; 
            }
            else if (year > 1000 && year % 400 == 0) 
            {
                return true;
            }
           return false;
        }
    }
}
