using System;

namespace day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Paraugs();


            Console.WriteLine();
            Console.ReadLine();
        }



        static void Paraugs()
        {
            int a, b, c, d;
            a = 1;
            b = 5;
            c = 7;
            d = 6;

            Console.WriteLine(a + " " + b + " " + c + " " + d);

            int[] masivs = new int[4];
            masivs[0] = 1;
            masivs[1] = 5;
            masivs[2] = 7;
            masivs[3] = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(masivs[i]);
            }

            //Console.ReadLine();
        }
    }
}
