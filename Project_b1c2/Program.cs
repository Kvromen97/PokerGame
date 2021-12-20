using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_b1c2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(65, 40);
            // removing scroll bars
            Console.BufferWidth = 65;
            Console.BufferHeight = 40;
            Console.Title = "Poker Game B1C2";
            DealCards dc = new DealCards();
            bool quit = false;

            while (!quit)
            {
                dc.Deal();

                char selection = ' ';
                while (!selection.Equals('Y') && !selection.Equals('N'))
                {
                    Console.WriteLine("Play Again? (Y-N)");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (selection.Equals('Y'))
                        quit = false;
                    else if (selection.Equals('N'))
                        quit = true;
                    else
                        Console.WriteLine("Invalid Selection. Please Try Again");
                }
            }

        }
    }
}
    