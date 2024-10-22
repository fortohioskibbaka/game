using System.Reflection.Emit;
using System;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.Design;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RND = new Random();
            bool done;
            
            int outcome;
            string answer, again;
            string headstails;
            int points;
                points = 3;

            Console.WriteLine("hello welcome to the game " +
                "here are the rules it will ask you heads or tails and for each you get right you get 1 point");

            done = false;
            while (!done)
            {
                Console.WriteLine("heads or tails");
                answer = Console.ReadLine().ToLower();
                outcome = RND.Next(2);
                if (outcome == 1 && answer == "tails")
                {

                    Console.WriteLine("tails your right");


                    points = points + 1;

                    Console.WriteLine("you have this many points " + points);




                }
                else if (outcome == 0 && answer == "heads")
                {


                    Console.WriteLine("heads your right");

                    points = points + 1;



                    Console.WriteLine("you have this many points " + points);



                }
                else if (outcome == 0 && answer == "tails")
                {


                    Console.WriteLine("heads your worng");

                    points = points - 1;




                    Console.WriteLine("you have this many points " + points);


                }
                else if (outcome == 1 && answer == "heads")
                {


                    Console.WriteLine("tails  your worng");

                    points = points - 1;




                    Console.WriteLine("you have this many points "  + points);


                }
                if (points == 0)
                {




                    done = true;


                    Console.WriteLine("dumby you lost ");

                }
                else
                {
                    Console.WriteLine("would you like to play agian");
                    again = Console.ReadLine().ToLower();



                    if (again == "no")
                    {

                        done = true ;


                    }






                }

















            }






















        }
    }
}
