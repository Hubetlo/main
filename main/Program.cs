using System;
using System.Threading;

class code
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter numberA: ");
            string aString = Console.ReadLine();
            
            if (aString == "quit") 
            {
                Console.WriteLine("Quitting...");
                Console.WriteLine(" ");
                break;
            }
            Thread.Sleep(1000);

            Console.WriteLine("Enter numberB: ");
            string bString = Console.ReadLine();
            
            if(bString == "quit")
            {
                Console.WriteLine("Quitting...");
                Console.WriteLine(" ");
                Thread.Sleep(2000);
                break;
            }
            

            int a = 0;
            int b = 0;
            if (int.TryParse(aString, out a) && int.TryParse(bString, out b))
            {
                if (a == b)
                {
                    Console.WriteLine("A is equal to B");
                }
                else if (a < b)
                {
                    Console.WriteLine("A is smaller than B");
                }
                else
                {
                    Console.WriteLine("A is bigger than B");
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid input: please enter valid integer values for numberA and numberB.");
                Console.WriteLine(" ");
            }

        }
    }
}