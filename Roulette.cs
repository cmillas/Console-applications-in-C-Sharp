using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro
            string intro = "Hello gambler! Let's paly a game of Roulette";
            Console.WriteLine(intro);

            while (true)
            {
                //Create a random number
                Random rnd = new Random();
                int number = rnd.Next(0, 38); //0 -37 (European style)
                string numstr = Convert.ToString(number);
                string redBlack= RedBlack();
                string highLow = HighLow();
                int intNumber = IntNumber();
                string strNumber = Convert.ToString(intNumber);
                string checkNum= CheckNumber(number);
                string [] check = checkNum.Split(' ');
                                

                if (redBlack == check[0] || highLow == check[1] || strNumber == numstr)
                {
                    if (numstr == "0")
                    {
                        check[0] = "green";
                        check[1] = "neither high nor low";
                    }
                    Console.WriteLine("You Win!!! The number was: "+ numstr + " which is " + check[1] + " and " + check[0] + ".");
                }
                else
                {
                    if (numstr == "0")
                    {
                        check[0] = "green";
                        check[1] = "neither high nor low";
                    }
                    Console.WriteLine("You lose! The nunmber was: " + numstr + " which is " + check[1] + " and " + check[0] + ".");
                }
                Console.WriteLine("Do you want to play again?");
                Console.Write("Y or N?");
                string ans = Console.ReadLine();
                if (ans.ToUpper() == "N")
                {
                    Console.WriteLine("Goodbye gambler!");
                    break;
                }else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }


        static string RedBlack()
        {
            Console.WriteLine("Do you want to Play Red or Black?");
            Console.Write("Y or N? ");
            string ans = Console.ReadLine();
            ans = ans.ToUpper();
            if (ans == "Y")
            {
                Console.Write("Red or Black? ");
                ans = Console.ReadLine();
                ans = ans.ToUpper();
                if (ans == "RED")
                {
                    return "red";
                }
                else
                {
                    return "black";
                }
            }
            else
            {
                return "N";
            }
        }

        static string HighLow()
        {
            Console.WriteLine("Do you want to High or Low?");
            Console.Write("Y or N? ");
            string ans = Console.ReadLine();
            ans = ans.ToUpper();
            if (ans == "Y")
            {
                Console.Write("High (19 -36) or Low (1 - 18)? ");
                ans = Console.ReadLine();
                ans = ans.ToUpper();
                if (ans == "HIGH")
                {
                    return "high";
                }
                else
                {
                    return "low";
                }
            }
            else
            {
                return "N";
            }
        }

        static int IntNumber()
        {
            Console.WriteLine("Do you want to bet on a specific number?");
            Console.Write("Y or N? ");
            string ans = Console.ReadLine();
            ans = ans.ToUpper();
            if (ans == "Y")
            {
                Console.Write("You can guess from 0 to 36: ");
                ans = Console.ReadLine();
                int num = Convert.ToInt32(ans);
                return num;
            }
            else
            {
                return -1;
            }
        }

        static string CheckNumber(int number)
        {
            string ans = "";
            if (number % 2 == 0 && number != 0)
            {
                ans = ans + "red ";
                //Console.WriteLine(ans);
            }
            if (number % 2 == 1)
            {
                ans = ans + "black ";
                //Console.WriteLine(ans);
            }
            if (number > 18)
            {
                ans = ans + "high ";
                //Console.WriteLine(ans);
            }
            if (number <= 18 && number != 0)
            {
                ans = ans + "low ";
                //Console.WriteLine(ans);
            }
            return ans;
        }
    }
}
