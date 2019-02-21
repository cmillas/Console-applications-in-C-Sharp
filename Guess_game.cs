using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quessing_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "skata";
            string quess = "";
            int quessNum = 1;
            while (secret != quess && quessNum <=3)
            {
                Console.Write("Quess a number: ");
                quess = Console.ReadLine();
                if(quess == secret)
                {
                    Console.WriteLine("You win!");
                    Console.ReadLine();
                }
                else
                {
                    quessNum++;
                    Console.WriteLine("Wrong quess!"); 
                }
            }
            Console.WriteLine("You lose!");
            Console.ReadLine();
        }
    }
}
