using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
          /*tringedalWinners = new string[3];

            Console.Write("Please enter the name of gold medal winner");
            medalWinners[0] = Console.ReadLine();
            Console.Write("Please enter rhe name of silver medal winner");
            medalWinners[1] = Console.ReadLine();
            Console.Write("Please enter the name of Bronze medal winner");
            medalWinners[2] = Console.ReadLine();*/

            //method
            int result = 0;
            string[] names = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Please enter the name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Which medal winner would you like to see..\n1 - Gold\n2 - Silver\n3 - Bronze");
           if(int.TryParse(Console.ReadLine(), out result)) 
           switch (result)
                    {
                        case 1:
                            Console.WriteLine($"Gold medal winner is - {names[result - 1]}");
                            break;
                        case 2:
                            Console.WriteLine($"Silver medal winner is - {names[result - 1]}");
                            break;
                        case 3:
                            Console.WriteLine($"Bronze medal winner is - {names[result - 1]}");
                            break;
                    }
                    Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            //qus 3
            string[] maori = { "Kia ora", "Nau mai", "Aroha", "Hui", };
            string[] english = { "Hello", "Welcome", "Love", "Gift" };

            Console.WriteLine("***********Translator App***********");
            Console.WriteLine("This app can translate the following words:");
            for (int i = 0; i < maori.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {english[i]}");
            }
            Console.Write("\nWhich word would you like translated to maori: ");


            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{english[input - 1]} translated into maori is: {maori[input - 1]}");

            Console.WriteLine("\nThankyou for using this app, press ENTER to quit...");
            Console.ReadLine();




        }
    }
}

