using System;
using System.Drawing;
using Console = Colorful.Console;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Area Calculator";
            var ContinusCheck = "y";
            while (ContinusCheck == "y")
            {
            start:
                string unit;
                string title = @"
     ________   ________   _______    ________          ________   ________   ___          
    |\   __  \ |\   __  \ |\  ___ \  |\   __  \        |\   ____\ |\   __  \ |\  \     
    \ \  \|\  \\ \  \|\  \\ \   __/| \ \  \|\  \       \ \  \___| \ \  \|\  \\ \  \     
     \ \   __  \\ \   _  _\\ \  \_|/__\ \   __  \       \ \  \     \ \   __  \\ \  \     
      \ \  \ \  \\ \  \\  \|\ \  \_|\ \\ \  \ \  \       \ \  \____ \ \  \ \  \\ \  \____ 
       \ \__\ \__\\ \__\\ _\ \ \_______\\ \__\ \__\       \ \_______\\ \__\ \__\\ \_______\
        \|__|\|__| \|__|\|__| \|_______| \|__|\|__|        \|_______| \|__|\|__| \|_______|     
                                                                                                    ";

                Console.WriteLine(title,Color.Pink);

                Console.WriteLine("Choose a unit of length and area measurement. \n1. Millimeter \n2. Centimeter. \n3. Meter.");
                Console.Write("Selected Unit : ");
                int SelectedUnit = int.Parse(Console.ReadLine());

                if (SelectedUnit == 1)
                {
                    unit = "mm.";
                }
                else if (SelectedUnit == 2)
                {
                    unit = "cm.";
                }
                else if (SelectedUnit == 3)
                {
                    unit = "m.";
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
                SelectedMenu:
                Console.WriteLine($"Choose the calculation you want to use.({unit}) \n1. Square Shape \n2. Triangle Shape \n3. Circle");

                Console.Write("Selected menu : ");
                int SelectedMenu = int.Parse(Console.ReadLine());


                switch (SelectedMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("please enter value ");
                            Console.Write("side of Square : ");

                            int sideofSquare = int.Parse(Console.ReadLine());
                            var SquareAreaResult = sideofSquare * sideofSquare;

                            Console.WriteLine($"Area of Square : {SquareAreaResult} {unit}2");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("please enter value ");

                            Console.Write("base of triangle : ");
                            int baseoftriangle = int.Parse(Console.ReadLine());

                            Console.Write("high of triangle : ");
                            int highoftriangle = int.Parse(Console.ReadLine());

                            var TriangleAreaResult = (baseoftriangle * highoftriangle) / 2;
                            Console.WriteLine($"Area of triangle : {TriangleAreaResult} {unit}2");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("please enter value ");

                            Console.Write("radius of triangle : ");
                            int radius = int.Parse(Console.ReadLine());

                            var CircleAreaResult = (22/7) * (radius * radius);
                            Console.WriteLine($"Area of Circle : {CircleAreaResult} {unit}2");
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            goto SelectedMenu;
                        }
                }

                Console.Write("You want to Continus ? (y/n) : ");
                ContinusCheck = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Good bye");
        }
    }
}
