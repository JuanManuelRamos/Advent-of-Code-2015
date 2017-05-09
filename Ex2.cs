using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2015
{
    class Ex2
    {
        private string[] gifts;
        private int length, width, height, extraPaper, squareFeet = 0;

        //Setter
        public void set_gifts(string filename)
        {
            gifts = Utilities.ridStringList(filename);
        }

        //Set Square Feet
        public void set_SquareFeet()
        {
            StringBuilder strB = new StringBuilder();
            int lwh = 0;
            int auxL;

            if (gifts.Length > 0)
                for (int i = 0; i < gifts.Length; i++)
                {
                    //Set length, width, height
                    for (int j = 0; j < gifts[i].Length; j++)
                    {
                        if (gifts[i][j] != 'x')
                            strB.Append(gifts[i][j]);
                        if (gifts[i][j] == 'x' || j == gifts[i].Length-1)
                        {
                            switch (lwh)
                            {
                                case 0:
                                    length = int.Parse(strB.ToString());
                                    break;
                                case 1:
                                    width = int.Parse(strB.ToString());
                                    break;
                                case 2:
                                    height = int.Parse(strB.ToString());
                                    break;
                            }                   
                            strB.Clear();
                            lwh++;
                        }
                    }
                    lwh = 0;

                    auxL = length;
                    length *= width;
                    width *= height;
                    height *= auxL;

                    set_ExtraPaper();
                    squareFeet += (2 * length + 2 * width + 2 * height) + extraPaper;
                }     
        }

        //Set Extra Paper
        public void set_ExtraPaper()
        {
            if (length <= width && length <= height)
                extraPaper = length;
            else if (width <= length && width <= height)
                extraPaper = width;
            else if (height <= length && height <= width)
                extraPaper = height;
        }   
        
        //Show Square Feet
        public void showSquareFeet()
        {
            Console.WriteLine("\nThe elves should order " + squareFeet + " square feet of wrapping paper.");
        } 
    }
}
