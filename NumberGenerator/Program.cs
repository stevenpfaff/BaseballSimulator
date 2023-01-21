using System;
using System.Linq;



namespace BaseballSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int single = 0;
            int doubles = 0;
            int triple = 0;
            int homerun = 0;
            int strikeout = 0;
            int walk = 0;
            int regout = 0;

            Random rnd = new Random();
            int[] intArr = new int[100];

            for (int i = 0; i < 100; i++)
            {
                int result = rnd.Next(1, 100);
                intArr[i] = result++;

                if (result < 36)

                {
                    Console.WriteLine("Strikeout");
                    strikeout++;
                }
                else if (36 < result && result < 66)
                {
                    Console.WriteLine("Walk");
                    walk++;
                }
                else if (66 < result && result < 82)
                {
                    Console.WriteLine("Out");
                    regout++;
                }
                else if (82 < result && result < 99)
                {
                    Console.WriteLine("Single");
                    single++;
                }
                else if (99 < result && result < 100)
                {
                    Console.WriteLine("Double!");
                    doubles++;
                }
                
            }
            Console.WriteLine("Hits {0}", single + doubles + triple + homerun);
            Console.WriteLine("Doubles{0}", doubles);
            Console.WriteLine("Strikeouts{0}", strikeout);
            Console.WriteLine("Walks{0}", walk);
            Console.WriteLine("At-Bats{0}", single + doubles+ triple + homerun + strikeout + regout);
            Console.WriteLine("Batting Average{0}", ((double)single + doubles + triple + homerun) / (single + doubles + triple + homerun + strikeout + regout));
            Console.ReadLine();


        }
    }
}

    
    


