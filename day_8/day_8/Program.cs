using System;

namespace day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paraugs();
            //JaunaZvaigznite();
            Skaitli();


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


        }

        static void JaunaZvaigznite()
        {
            string mainigais = "";
            string mainigais2 = "";
            string[] zvaigznites = new string[3];
            zvaigznites[0] = "*";
            zvaigznites[1] = "**";
            zvaigznites[2] = "***";

            for (int i = 0; i < 3; i++)

            {
                if (i == 1)
                {
                    mainigais = zvaigznites[i];
                }
                Console.WriteLine(zvaigznites[i]);

                if (i == 0)
                {
                    mainigais2 = zvaigznites[i];
                }
                ;

            }
        }

        static void Skaitli()
        {
            int[] izvade = new int[5];
            string[] ievade = new string[5];

            for (int i = 0; i < 5; i++)
            {

                ievade[i] = Console.ReadLine();
                Console.Clear();
               
                izvade[i] = Convert.ToInt16(ievade[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(izvade[i]  );
            }

            Console.WriteLine(izvade[0] + izvade[1] + izvade[2] + izvade[3] + izvade[4]);




        }
    }
}
