using System;


namespace BaseballSimulator
{
    class Simulator
    {
        static void Main(string[] args)
        {
            do
            {
                Simulate();
                Console.WriteLine("Run again? y or n");
            } while (Console.ReadLine().ToLower() == "y");
        }
        private static void Simulate()
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
                if (result < 5)
                {
                    strikeout++;
                }
                else if (5 < result && result < 6)
                {
                    walk++;
                }
                else if (6 < result && result < 46)
                {
                    regout++;
                }
                else if (46 < result && result < 66)
                {
                    single++;
                }
                else if (66 < result && result < 78)
                {
                    doubles++;
                }
                else if (78 < result && result < 79)
                {
                    triple++;
                }
                else if (80 < result && result < 100)
                {
                    homerun++;
                }
            }
            Console.WriteLine("Hits {0}", single + doubles + triple + homerun);
            Console.WriteLine("Doubles{0}", doubles);
            Console.WriteLine("Triples{0}", triple);
            Console.WriteLine("Homeruns{0}", homerun);
            Console.WriteLine("Strikeouts{0}", strikeout);
            Console.WriteLine("Walks{0}", walk);
            Console.WriteLine("At-Bats{0}", single + doubles + triple + homerun + strikeout + regout);
            Console.WriteLine("Batting Average{0}", ((double)single + doubles + triple + homerun) / (single + doubles + triple + homerun + strikeout + regout));
            Console.WriteLine("On Base Percentage{0}", ((double)single + doubles + triple + homerun + walk) / (single + doubles + triple + homerun + strikeout + regout + walk));
            Console.WriteLine("Slugging Percentage{0}", ((double)single + (doubles * 2) + (triple * 3) + (homerun * 4)) / (single + doubles + triple + homerun + strikeout + regout));
            Console.ReadLine();
            Console.WriteLine("Press ENTER to run again");
        }
    }
}


