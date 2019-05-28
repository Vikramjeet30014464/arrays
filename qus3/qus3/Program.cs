using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qus3
{
    class Program
    {
        static void Main(string[] args)
        {
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
