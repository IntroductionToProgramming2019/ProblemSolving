/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : real life problem solving
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            double litres_per_tank = 60;
            double miles_per_litre = 14;
            double miles = 2000;
            double fills = miles / miles_per_litre / litres_per_tank;
            Console.WriteLine("Your car will have to be filled {0:0.00} times",fills);
            Console.WriteLine();
            double gallons = 3.78;
            //litres
            double travel =  (10 * gallons) * miles_per_litre;
            Console.WriteLine("You will travel {0:0.00} miles on 10 gallons of fuel", travel );
            Console.WriteLine();
        }
    }
}
