using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;
            displayMenu(menuChoice);
                   

        }

        static private int displayMenu(int menuChoice)
        {
        begining:
            Console.Write("1. Future Value \n2. Present Value \n3. Exit \nEnter Choice: ");
           
            menuChoiceReset: //jumps here if parse returns false to recycle the parse//
            

            if (int.TryParse(Console.ReadLine(), out menuChoice))
            {


                do
                {
                    if (menuChoice < 1 || menuChoice > 3)
                    {
                        Console.Write("Invalid - try again: ");
                        menuChoice = int.Parse(Console.ReadLine());
                    }
                }
                while (menuChoice < 1 || menuChoice > 3);
            }
            else
            {
                Console.Write("Invalid - try again: ");
                goto menuChoiceReset;
            }
            return menuChoice;
        }
            
            static private  int getMenuChoice(int userChoice)
            {
                userChoice = displayMenu().menuChoice;
            }
            
           
            
        }

        static private float futureValue(float _rate, int _years, float _amount)
        {


            _rate = _rate / 1200;
            _rate = _rate + 1;
           _years *= 12;
           _rate = (float)Math.Pow(_rate, _years);
           float total = _amount + _rate;

           return total;

        }


    }
}
