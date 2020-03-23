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

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare values that you know, as you will be using them in calculations//
            int chicken = 2;
            int sheep = 4;
            int total_animals = 87;
            int total_legs = 266;
            //divide the amount of legs by the lowest value of legs on an aniaml to see if the number of that animal is too great//
            int ans = total_legs / chicken;
            //  Console.WriteLine(ans);
            //as you can see, the value ans > total_animals, therefore, subtract the value total_animals(87) from the number of chickens in ans//
            int numSheep = ans - 87;
            //this gives you the number of sheep//
            // Console.WriteLine(numSheep);
            //to find the number of chickens, simply take the number of sheep away from the total animals and the remainder is  the amount of chickens//
            int numChickens = total_animals - numSheep;
            //Console.WriteLine(numChickens);


            Console.WriteLine("The total number of chickens is {0}", numChickens);
            Console.WriteLine("The total number of sheep is {0}", numSheep);



        }
    }
}
