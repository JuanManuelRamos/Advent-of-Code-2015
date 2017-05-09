using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Advent_of_Code_2015
{
    class Program
    {
        static void Main()
        {
            int excercise = 0;




            Console.WriteLine("\n\n              Welcome to Advent of Code 2015\n\n        ");
            
            Console.WriteLine("                         *                           25");
            Console.WriteLine("                        >o<                          24");
            Console.WriteLine("                       >0>o<                         23");
            Console.WriteLine("                      >o<<0<<                        22");
            Console.WriteLine("                     >*<o>>0<<                       21");
            Console.WriteLine("                    >@<0<*>>0<<                      20");
            Console.WriteLine("                   >>*>>>*>>>o<<                     19");
            Console.WriteLine("                  >*<<0<<@<<<*>0<                    18");
            Console.WriteLine("                 >*>>0>>>0<<<@<<o<                   17");
            Console.WriteLine("                >0>>@>>>@>*>@<<*<*<                  16");
            Console.WriteLine("               >o>o<<<0>>>*<<o<<0<0<                 15");
            Console.WriteLine("              >>0<o<<<o<<*<<<o<<<*<<<                14");
            Console.WriteLine("             >*>*>>>0>@<<0>>>0>0<<<*<<               13");
            Console.WriteLine("            >>@>@>o>>0>0<*>>>o>>0>>>o<<              12");
            Console.WriteLine("           >>@>>*<@>>>*>0>*>>@<<o>>o>>o<             11");
            Console.WriteLine("          >>o<<0<<@<<@<o<o>>>@<@>*<<<*<<<            10");
            Console.WriteLine("         >0<<o<<<0>o>>@>>>*<o>>>@>*>o<<0<<           9");
            Console.WriteLine("        >o<<<@<<o<*<0<<<0>0<<<*<0>>>*>>@>0<          8");
            Console.WriteLine("       >o>>*<o>*>>@>>0>>o<o<*>>0<<<*<<0<<<0<         7");
            Console.WriteLine("      >o<<*>>@<<o<0<<<o>>>0>o>>o>*>>>0>>>@<<<        6");
            Console.WriteLine("     >*>o>>0>>>o<<*<o<<<*>>>*>>>o>o>>o>*>>@>o<       5");
            Console.WriteLine("    >>o>@<<<o>>>*<<<0<0<0>>>0>>>@>>0<<<o>>@<<<<      4");
            Console.WriteLine("   >>o>>@<*>>0>*>>>@<<@<*<@<<<o>>>o<<<o<@<<<*<*<     3");
            Console.WriteLine("  >*<@<<o<<<0>>>*<<@<<@<@>>>*>>*<*>>>*<*>>o>>>0>>    2");
            Console.WriteLine(" >*<<0<<o>o<*>>@>o<<<o<<o>0>>>*<<@>*<<<@<@<<<0>*<<   1");
            Console.WriteLine("                       |   |                          ");
            Console.WriteLine("                       |   |                          ");
            Console.WriteLine("           _  _ __ ___ |___| ___ __ _  _              ");

            do
            {
                Console.Write("\nPlease select an exercise: ");
                excercise = (int)Console.Read()-48;
            }
            while (excercise <= 0 || excercise > 25);

            switch(excercise)
            {
                case 1:
                    Ex1 ex1 = new Ex1();
                    ex1.set_floors(Utilities.ridString(@"..\..\Resources\Ex1.txt"));
                    ex1.set_numFloor();
                    ex1.showRightFloor();
                break;

                case 2:
                    Ex2 ex2 = new Ex2();
                    ex2.set_gifts(@"..\..\Resources\Ex2.txt");
                    ex2.set_SquareFeet();
                    ex2.showSquareFeet();
                break;

                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
            }
            




            



            Console.ReadKey();
        }
    }
}
