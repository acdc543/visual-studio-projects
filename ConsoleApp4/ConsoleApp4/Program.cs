using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Wizard Quest!");
            Console.WriteLine("              '/\'         ");
            Console.WriteLine("         ____'/  \'____    ");
            Console.WriteLine("         '\'         ' /'    ");
            Console.WriteLine("          '\'/'\'/'\'/'\'/'\'/'     ");
            Console.WriteLine("          [][][][][]     ");
            Console.WriteLine("                         ");
            Console.WriteLine("                         ");
            Console.WriteLine("Welcome, To Wizard Quest. To Start");
            Console.WriteLine("Make a character # selection then hit, ENTER.");
            Console.WriteLine("                    ");
            Console.WriteLine("Dark Wizard - 1");
            Console.WriteLine("Light Wizard - 2");
            Console.WriteLine("Knight - 3");
            Console.WriteLine("Thief - 4");
            Console.WriteLine("                    ");
            Console.Write("Choose Character: ");
            string character = Console.ReadLine();

            

            if (character == "1")
            {
                Console.WriteLine("                    ");
                Console.WriteLine("Congratulations!, You have chosen");
                Console.WriteLine("to play as a Dark Wizard.");
            }

            else if (character == "2")
            {
                Console.WriteLine("                    ");
                Console.WriteLine("Congratulations!, You have chosen");
                Console.WriteLine("to play as a Light Wizard.");
            }

            else if (character == "3")
            {
                Console.WriteLine("                    ");
                Console.WriteLine("Congratulations!, You have chosen");
                Console.WriteLine("to play as a Knight.");
            }

            else if (character == "4")
            {
                Console.WriteLine("                    ");
                Console.WriteLine("Congratulations!, You have chosen");
                Console.WriteLine("to play as a Thief.");
            }

            else
            {
                Console.WriteLine("                    ");
                Console.WriteLine("Sorry, That is not a valid selection!");
            }
            Console.ReadLine();
            



        }
    }
}
