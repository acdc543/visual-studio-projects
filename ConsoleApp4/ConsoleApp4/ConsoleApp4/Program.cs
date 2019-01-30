using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4

{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Wizard Quest!");
            Console.WriteLine(@"              /\         ");
            Console.WriteLine(@"         ____/  \____    ");
            Console.WriteLine(@"         \          /    ");
            Console.WriteLine(@"          \/\/\/\/\/     ");
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

        RESELECT:

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
                goto RESELECT;
            }
            Console.WriteLine(" ");
            Console.Write("Hit Any key to continue:");
            Console.ReadKey();

            Console.Clear();

            Console.Write("What is your characters name:");
            Player.playerName = Console.ReadLine();

            Console.Clear();

            if (character == "1")
            {
                Console.WriteLine(DarkWizard.storyLine);
            }

            else if (character == "2")
            {
                Console.WriteLine(LightWizard.storyLine);
            }

            else if (character == "3")
            {
                Console.WriteLine(Knight.storyLine);
            }

            else if (character == "4")
            {
                Console.WriteLine(Thief.storyLine);
            }

            Console.ReadLine();            



        }
    }
}
