using System;

namespace CoceptosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts!");

            Date date1 = new Date(2022, 08, 02);
            try
            {
                Console.WriteLine(new Date(2024, 2, 29));
                Console.WriteLine(new Date(1974, 11, 03));
                Console.WriteLine(new Date(1985, 11, 31));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
             
            }
        }
    }
}
