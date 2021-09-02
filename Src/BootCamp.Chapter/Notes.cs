using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Notes
    {
        /*
         * Chapter 3
         * Lesson 5: Jagged and Multidimensional Arrays, Dictionary
         * 
         *  n-Dimensional Array
         *      - An array 0f arrays
         *      - Can have 3d, 4d, and so on
         *      - you should consider encapsulating and abstracting for more than 2 dimensional 
         *      
         *      ex:
         *          int[,] table = new int[2,2];
         *          table[0] = new int [0,0];
         *          table[1] = new int [0,1];
         * 
         *  Jagged Array
         *      - arrays do not have to be consistent in size
         *      - you must define how many initial arrays you are going to have, and then define array size for each later
         *      ex:
         *          int[][] table = new int[2][];
         *          table[0] = new int [2];
         *          table[1] = new int [4];
         *          
         *  Dictionary
         *      - A key value pair
         *      - A way to map a key to value
         *      - a translaction mechanism
         *      - similar to a list, generic, and stores many things
         *      - but always has 2 generic paramaters <TKey, TValue>
         *      - and only stores key-value pairs
         *      - Dictionaries are faster than lists, great for mappings, and solving certain problems
         *      
         *      ex:
         *          Dictionary <int, string> numbers = new Dictionary (int, string>()
         *          {
         *                  {0, "Zero"},
         *                  {1, "One"},
         *                  {2, "Two"}
         *          }
         */

    }
}
