using System;

namespace RekenVoorbeeld
{
    class Program
    {
        public static String Naam = NaamWeergeven();
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam?");            
            UitReken();
        }
        static void UitReken()
        {
              int goede = 0;
              int aantal = 0;
            
            while (aantal < 4)
            {
                Console.WriteLine("Hoi " + Naam);
                Random ran = new Random();

                int x = ran.Next(1, 10);
                int y = ran.Next(1, 10);

                int uitkomt = x + y;
                Console.WriteLine("Hoeveel is " + x + " + " + y + " bij elkaar?");

                int invoer = Convert.ToInt32(Console.ReadLine());

                if (invoer == uitkomt)
                {
                    goede++;
                    aantal++;
                    Console.WriteLine("Goed geantwoord! Je score is: " + goede.ToString());
                }
                else
                {
                    if (goede <= 0)
                    {
                        goede = 0;
                    }
                    else
                    {
                        goede--;
                    }
                    aantal++;
                    Console.WriteLine("Helaas niet goed geantwoord! Je score is:" + goede.ToString());
                }
            }
        }

        public static string NaamWeergeven()
        {
            string naam = Convert.ToString(Console.ReadLine());
            return naam;
        }
    }
}

