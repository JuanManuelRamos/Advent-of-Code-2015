using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2015
{
    class Utilities
    {
        //Read Input Data - return a string
        public static string ridString(string filename)
        {
            return System.IO.File.ReadAllText(filename);
        }

        //Read Input Data - return a string[]
        public static string[] ridStringList(string filename)
        {
            return System.IO.File.ReadAllLines(filename);
        }
    }
}