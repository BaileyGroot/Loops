using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave A

            for (int a = 0; a < 100; a++)

            {

                if (a < 50)

                {

                    Console.WriteLine(a);

                }

            }



            Console.ReadKey();




            // Opgave B



            int i = 0;

            while (i < 100)

            {

                if (i < 50)

                {

                    Console.WriteLine(i);

                    i++;

                }

            }



            Console.ReadKey();

          
            // Opgave C



            for (int b = 100; b > 0; b--)

            {

                Console.WriteLine(b);

            }



            Console.ReadKey();
        }
    }
}
