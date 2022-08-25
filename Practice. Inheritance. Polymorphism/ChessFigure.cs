using System;

namespace SoftServe.Practice._Inheritance._Polymorphism
{
    public abstract class ChessFigure
    {
        public abstract void Move();
    }

    public class Bishop : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves by a diagonal!");
        }
    }

    public class Rook : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves straight!");
        }
    }
}
