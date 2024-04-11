using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Periode3Csharpgame
{
    internal class Menu
    {
        /*MainMenu mainMenu = new MainMenu();
        MenuMove menuMove = new MenuMove();
        MenuItems menuItems = new MenuItems();

        List<Menu> menuList = new List<Menu>();*/

        public static string[] menuMain = {"Move", "Interact", "Repair", "Place marker" };
        public static string[] menuMove = { "Up", "Down", "Left", "Right" };


        public static int menuController = 0;

        public static string[] menuLists = {"Main", "Move", "Items"};

        public static int[] menuNumber = {1, 2, 3};
        public static bool isRunning = true;
        public static int selectedOption;

        public string test;

        /*public void addingToList()
        {
            menuList.Add(new Menu());
            menuList.Add(new MenuMove())
        }*/

        public static void printMenu(string[] menu)
        {
            Grid.gridOne();

            for (int i = 0; i < menu.Length; i++)
            {
                if (i == menuController)
                {
                    Console.WriteLine(menu[i], Console.ForegroundColor = ConsoleColor.Green);
                    Console.ForegroundColor = ConsoleColor.Gray;

                    i = selectedOption;
                }
                else
                {
                    Console.WriteLine(menu[i], Console.ForegroundColor = ConsoleColor.Gray);
                }
            }

            keyDetection(menu, selectedOption);
        }

        public static void keyDetection(string[] menu, int selOpt)
        {
            char input = Console.ReadKey().KeyChar;
            Console.Clear();
            if (input == 'w')
            {
                if(menuController - 1 >= 0)
                {
                    menuController--;
                }
                else
                {
                    menuController = menu.Length - 1;
                }

                printMenu(menu);
            }
            else if (input == 's')
            {
                if (menuController + 1 < menu.Length)
                {
                    menuController++;
                }
                else
                {
                    menuController = 0;
                }

                printMenu(menu);
            }
            else if(input == 'f')
            {
                isRunning = false;
            }
            else if(input == 'e')
            {
                menuSelection(menu, selOpt);
            }
        }
    }
}
