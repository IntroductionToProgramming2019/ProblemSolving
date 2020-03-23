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
            double diagonal_of_floor = 4;
            double diagonal_of_room = System.Math.Sqrt((diagonal_of_floor * diagonal_of_floor) + (height * height));
            Console.WriteLine(diagonal_of_room);

        }
    }
}
