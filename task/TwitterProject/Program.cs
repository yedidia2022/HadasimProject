using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("enter one to Rectangle Tower, two to Triangular Tower, three to exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter a Rectangle height");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter a Rectangle width");
                        int width = int.Parse(Console.ReadLine());
                        RactangleTower rec = new RactangleTower(height, width);
                        rec.checkBetweenaRctangleToSquare();
                        break;
                    case 2:
                        Console.WriteLine("enter a Triangular height");
                        height = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter a Triangular width");
                        width = int.Parse(Console.ReadLine());
                        TriangularTower tri = new TriangularTower(height, width);
                        Console.WriteLine("to calc the triangular scope press 1, to print the triangular please press 2, back to menu click any key ");
                        int option = int.Parse(Console.ReadLine());
                        while (option ==1|option==2)
                        { 
                            if (option == 1)
                            {
                                tri.calcScope();
                                Console.WriteLine("to calc the triangular scope press 1, to print the triangular please press 2, back to menu click any key ");
                                option = int.Parse(Console.ReadLine());
                            }
                            else
                                if (option == 2)
                            {
                                tri.printTheTriangular();
                                Console.WriteLine("to calc the triangular scope press 1, to print the triangular please press 2, back to menu click any key ");
                                option = int.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("we hope you enjoy");
                        break;
                    default:
                        Console.WriteLine("enter a valid number");
                        break;
                }


            }
            




        }
    }
}
