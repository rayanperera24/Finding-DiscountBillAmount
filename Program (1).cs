using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Activity___2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter amount of the bill");
            int amount = Convert.ToInt32(Console.ReadLine());

            int rate;
            Console.WriteLine("Enter the discount rate : ");
            rate = Convert.ToInt32(Console.ReadLine());

           
            int finalprice;
            finalprice= amount * rate / 100;
            Console.WriteLine("Your Discount : "+finalprice);

            int dprice;
            dprice = amount - finalprice;
            Console.WriteLine("Your Discounted Price will be :"+dprice);








            Console.ReadKey();


        }
    }
}
