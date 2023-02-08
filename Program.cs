using Solution2Group11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2Group11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter radius:");

            var isValid = true;

            var C = new Circle();
            do
            {
                try
                {
                    int radius = Convert.ToInt32(Console.ReadLine());
                    if (radius > 0)
                    {
                        isValid = true;
                        C = new Circle(radius);
                    }
                    else
                    {
                        isValid = false;
                        Console.WriteLine("\nPlease enter radius more than 0");
                    }
                }
                catch
                {
                    Console.WriteLine("\nPlease enter valid radius");
                    isValid = false;
                }
            } while (!isValid);

            //while loop for selection of menu
            while (true)
            {

                //variable declared for entered choice no from user
                int choice = showMenu();

                //switch case for every menu choices to get value according to choices
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nRadius of circle:" + C.GetRadius());
                        break;
                    case 2:
                        Console.WriteLine("\nEnter radius from command line:");
                        var isValidRadius = true;
                        do
                        {
                            try
                            {
                                int user_radius = Convert.ToInt32((Console.ReadLine()));
                                if (user_radius < 1)
                                {
                                    Console.WriteLine("\nRadius should be greater than zero ");
                                }
                                else
                                {
                                    C.SetRadius(user_radius);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("\nPlease enter valid radius");
                                isValidRadius = false;
                            }
                        } while (!isValidRadius);
                        break;
                    case 3:
                        Console.WriteLine("\nCircumference of circle:" + C.GetCircumference());
                        break;
                    case 4:
                        Console.WriteLine("\nArea of circle:" + C.GetArea());
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("\nPlease enter valid choice");
                        break;
                }
            }
        }

        public static int showMenu()
        {
            var menu = 0;
            do
            {
                try
                {

                    Console.WriteLine("\nPlease select from following option");
                    Console.WriteLine("===================================");

                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circunference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");

                    menu = int.Parse(Console.ReadLine() ?? "0");
                }
                catch
                {
                    menu = 0;
                    Console.WriteLine("\nPlease enter valid menu option");
                }
            } while (menu == 0);

            return menu;
        }
    }
}