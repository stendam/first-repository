using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shutdown = false;
            bool foundResponse = false;
            string inputValue;
            string outputValue = "";


            Console.WriteLine("Computer: Hello!");

            while (!shutdown)
            {
                foundResponse = false;


                Console.Write("User:");
                inputValue = Console.ReadLine().ToLower(); 

                Console.Write("Computer:");
                switch (inputValue)
                {
                    case "hello":
                        outputValue = "I've already said hello.";
                        foundResponse = true;
                        break;

                    case "bye":
                        outputValue = "Goodbye";
                        foundResponse = true;
                        break;

                    case "What's up?":
                        outputValue = "Im fine, thanks. What about you?";
                        foundResponse = true;
                        break;


                    case "Jak się nazywasz?":
                        outputValue = "James";
                        foundResponse = true;
                        break;

                    case "Mój ulubiony kolor to niebieski.":
                        outputValue = "Dlaczego?";
                        foundResponse = true;
                        break;

                }
                if (foundResponse)
                {
                    Console.WriteLine(outputValue);
                }
                else
                {
                    Console.WriteLine("Ok");
                }


            }
        }
    }
}
