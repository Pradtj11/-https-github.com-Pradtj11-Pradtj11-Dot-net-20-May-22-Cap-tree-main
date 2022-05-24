using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row=0; row<5; row++)
            {
                for(int col=5; col<row; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for(int row=0; row<5; row++)
            {
                for(int col=0; col<row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
            
    }
}
