using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge364___Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInput;
            Console.WriteLine("Enter XdY where x is the number of dice and y the number of sides on each die. \nType 'END' or leave blank to quit. \nexample: 4d6 rolls four six-sided dice.\n");
            sInput = Console.ReadLine();

            while (sInput != "" && sInput.ToLower() != "end")
            {
                string[] sParts = sInput.Split('d');
                int iLeft;
                int iRight;

                try
                {
                    if (int.TryParse(sParts[0], out iLeft) && int.TryParse(sParts[1], out iRight))
                        RollDice(iLeft, iRight);
                    else
                        Console.WriteLine("Format not recognized. Please use correct format.");
                }
                catch
                {
                    Console.WriteLine("Format not recognized. Please use correct format.");
                }
                sInput = Console.ReadLine();                  
            }

        }

        static void RollDice(int iLeft, int iRight)
        {
            Random rnd = new Random();
            int[] iResults = new int[iLeft];
            int iTotal = 0;

            for (int i = 0; i < iLeft; i++)
            {
                iResults[i] = rnd.Next(1, iRight);
                iTotal += iResults[i];
            }

            Console.Write("Rolled "+iLeft+"d"+iRight+": " + iTotal + " [ ");
            for (int i = 0; i < iLeft; i++)
                Console.Write(iResults[i] + " ");

            Console.Write("]\n");
        }
    }
}
