using System;

namespace pag123Book
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two color variables
            Color red = new Color(255, 0, 0);
            Color purple = new Color(255, 0, 255);

            // Define ball
            Ball redBall = new Ball(red, 5);
            Ball purpleBall = new Ball(purple, 10);

            // Get Red ball properties
            Console.WriteLine($"RedBall = ({purple.ColorRed}, {purple.ColorGreen}, " +
                $"{purple.ColorBlue})");

            // Throw Ball
            redBall.Throw();
            redBall.Throw();
            redBall.Throw();
            Console.WriteLine(redBall.ThrowTimes);

            // Pop and throw 
            purpleBall.Pop();
            purpleBall.Throw();
            Console.WriteLine(purpleBall.ThrowTimes);

            Console.ReadKey();

        }
    }
}
