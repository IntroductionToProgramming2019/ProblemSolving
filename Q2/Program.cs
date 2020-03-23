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

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*these questions require splitting the room in two and finding the hypotenuses of triangles to find diagonals, 
            which are the shortest routes*/
            double length = 3.2;
            double width = 2.4;
            double height = 3.0;
            double diagonal_of_floor = System.Math.Sqrt((length * length) + (width * width));
            double ans = height + diagonal_of_floor;
            Console.WriteLine(ans);

        }
    }
}
