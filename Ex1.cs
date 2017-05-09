using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2015
{
    class Ex1
    {
        private string floors = "";
        private int numFloor = 0;

        //Setter
        public void set_floors(string str)
        {
            floors = str;
        }

        //Set the right floor (get from input data)
        public void set_numFloor()
        {
            numFloor = 0;
            for(int i = 0; i < floors.Length; i++)
                if (floors[i] == '(')
                    numFloor++;
                else if (floors[i] == ')')
                    numFloor--; 
        }

        //Show Data
        public void showData()
        {
            Console.WriteLine(floors);
        }

        //Show right floor
        public void showRightFloor()
        {
            Console.WriteLine("\n\nSanta must go to floor number " + numFloor);
        }
    }


}
