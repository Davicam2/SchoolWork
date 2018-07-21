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
            bool reset = false;
            while (reset == false)
            {
                displayMenu();
            }
            

        }

        static private void displayMenu()
        {
 
            Console.Write("1. Future Value \n2. Present Value \n3. Exit \nEnter Choice: ");
            string menuChoice = Console.ReadLine();
            getMenuChoice(menuChoice);
            
        }

        static private void getMenuChoice(string userChoice)
        {
            int intUserChoice = 0;

        reParseMenuChoice:
            if (int.TryParse(userChoice, out intUserChoice) == false)
            {                   
                    Console.WriteLine("Invalid - try again: ");
                    //Console.WriteLine("invalid string test");
                    userChoice = Console.ReadLine();
                    goto reParseMenuChoice;               
            }
            else
            {

                if (intUserChoice < 1 || intUserChoice > 3)
                {
                    Console.WriteLine("Invalid - try again: ");
                    //Console.WriteLine("invalid number test");
                    userChoice = Console.ReadLine();
                    goto reParseMenuChoice;
                }
                else
                {
                    switch (intUserChoice)
                    {
                        case 1:
                            futureValue();
                            displayMenu(); 
                            break;
                        case 2:
                            presentValue();
                            displayMenu(); 
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                    

                    
                }
                
            }
        }
        
        /// <summary>
        /// block of code containing the future value, present value menus and checks.
        /// </summary>
        static private void futureValue()
        {
            float rate = 0;
            int years = 0;
            float amount = 0;
            Console.Write("Future value of investment amount today");

            rate = getRate(rate);
            years = getYears(years);
            amount = getAmount(amount);

            float totalFutureValue = futureValue(rate, years, amount);
            
            Console.WriteLine("Future Value is $" + totalFutureValue);
            
        }
        static private void presentValue()
        {
            float rate = 0;
            int years = 0;
            float amount = 0;

            rate = getRate(rate);
            years = getYears(years);
            amount = getAmount(amount);

            float totalPresentValue = presentValue(rate, years, amount);
            Console.WriteLine("Present Value is $" + totalPresentValue);

        }
        
        //getRate method//
        static private float getRate(float rate)
        {
            float goodRate;
            Console.Write("\nEnter Rate between 2.75 and 12.25: ");
            string testGoodRate = Console.ReadLine();
        goodRateReParse:
            if (float.TryParse(testGoodRate, out goodRate))  //if it is a float it will exicute this code//
            {
                if (goodRate < 2.75 || goodRate > 12.25)            //if it is NOT a correct float this will exicute, and recycle//
                {
                    Console.WriteLine("Invalid - try again: ");
                    //Console.WriteLine("goodRateTest is a number, goodRateTest is not a correct number");
                    testGoodRate = Console.ReadLine();
                    goto goodRateReParse;
                }
                else
                {
                    return goodRate; //exit sequence from loop//
                }
            }
            else     //will jump here if goodRate is not a float//
           
            {
                Console.WriteLine("Invalid - try again: ");
               // Console.WriteLine("goodRateTest is not a number");
                testGoodRate = Console.ReadLine();
                goto goodRateReParse;
            }                                                       
        }




        //getYears method//
        static private int getYears(int years)
        {
            int goodYears;
            Console.Write("\nEnter Years between 5 and 30: ");
            string testGoodYears = Console.ReadLine();
        goodYearsReParse:
            if (int.TryParse(testGoodYears, out goodYears))  //if it is a float it will exicute this code//
            {
                if (goodYears < 5 || goodYears > 30)            //if it is NOT a correct float this will exicute, and recycle//
                {
                    Console.WriteLine("Invalid - try again: ");
                    //Console.WriteLine("goodRateTest is a number, goodRateTest is not a correct number");
                    testGoodYears = Console.ReadLine();
                    goto goodYearsReParse;
                }
                else
                {
                    return goodYears; //exit sequence from loop//
                }
            }
            else     //will jump here if goodRate is not a float//
            {
                Console.WriteLine("Invalid - try again: ");
                //Console.WriteLine("goodRateTest is not a number");
                testGoodYears = Console.ReadLine();
                goto goodYearsReParse;
            }
        }


        // get Amount method//
        static private float getAmount(float Amount)
        {
            float goodAmount;
            Console.Write("\nEnter Amount between 10 and 20000: ");
            string testGoodAmount = Console.ReadLine();
        goodAmountReParse:
            if (float.TryParse(testGoodAmount, out goodAmount))  //if it is a float it will exicute this code//
            {
                if (goodAmount < 10 || goodAmount > 20000)            //if it is NOT a correct float this will exicute, and recycle//
                {
                    Console.WriteLine("Invalid - try again: ");
                    //Console.WriteLine("goodAmountTest is a number, goodAmountTest is not a correct number");
                    testGoodAmount = Console.ReadLine();
                    goto goodAmountReParse;
                }
                else
                {
                    return goodAmount; //exit sequence from loop//
                }
            }
            else     //will jump here if goodRate is not a float//
            {
                Console.WriteLine("Invalid - try again: ");
                //Console.WriteLine("goodAmountTest is not a number");
                testGoodAmount = Console.ReadLine();
                goto goodAmountReParse;
            }
        }
        /// <summary>
        /// end block for rate, years, amount inputs for future/present value. 
        /// Begining block for arithmatic executions for future and present value. 
        /// </summary>
        /// <param name="_rate"></param>
        /// <param name="_years"></param>
        /// <param name="_amount"></param>
        /// <returns> total </returns>

        public static float futureValue(float _rate, int _years, float _amount)
        {

            
            _rate /=  1200;
            _rate += 1;
            _years *= 12;
            _rate = (float)Math.Pow(_rate, _years);
            float total = _amount * _rate;

            return total;

        }

        public static float presentValue(float _rate, int _years, float _amount)
        {
            _rate /= 1200;
            _rate += 1;
            _years *= 12;
            _rate = (float)Math.Pow(_rate, _years);
            float total = _amount / _rate;
            return total;

        }
        
        
        
        
    }
    
}
