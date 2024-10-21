using System.Reflection.Emit;
using System;
using static System.Formats.Asn1.AsnWriter;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            bool done;
            int flip;
            int outcome;
            string answer;
            string headstails;
            int points;
                points = 3;

            Console.WriteLine("hello welcome to the game " +
                "here are the rules it will ask you heads or tails and for each you get right you get 1 point");

            Console.WriteLine("would you like to play");
            answer = Console.ReadLine();
            Console.WriteLine("heads or tails");
            headstails = Console.ReadLine();

            flip = generator.Next(0, 3);
            outcome = flip;

            if (answer == "yes")
            {
               
                while (outcome > 1)
                {
                    Console.WriteLine("heads ");


                    if (headstails == "heads")
                    {
                        while (outcome > 1)
                        {
                            Console.WriteLine("heads ");

                            Console.WriteLine("you have " + points + 1 );



                            if (answer == "no")
                            {






                                done = true;
                            }

                            

                        }








                    }







                }






            }
           



            














        }
    }
}
