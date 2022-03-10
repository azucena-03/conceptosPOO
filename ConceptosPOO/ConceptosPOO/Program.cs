using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO concepts!");
            Console.WriteLine("=============");

            try
            {
                Console.WriteLine(new Date(29, 2, 2024));
                Console.WriteLine(new Date(12, 6, 1997));
                Console.WriteLine(new Date(30, 11, 2003));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
    }
}
