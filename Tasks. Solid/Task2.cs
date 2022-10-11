using System;

namespace SoftServe_IT_Academy.Tasks._Solid
{
    public interface IFlyable
    {
        void Fly();
    }
    public interface IEating
    {
        void Eat();
    }
    public interface IMoving
    {
        void Move();
    }
    public interface IBasking
    {
        void Bask();
    }
    public interface IKryaking
    {
        void Krya();
    }
    public class Bird : IFlyable, IEating, IMoving, IKryaking
    {
        public virtual void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }

        public virtual void Krya()
        {
            Console.WriteLine("Krya-Krya!");
        }
        public virtual void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
    public class Cat : IMoving, IEating, IBasking
    {
        public void Bask()
        {
            Console.WriteLine("Mrrr-Mrrr-Mrrr...");
        }

        public void Eat()
        {
            Console.WriteLine("Oh! My milk!");
        }

        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
    public class Duck : Bird
    {
        public override void Move()
        {
            Console.WriteLine("I can swimm!");
        }
    }
    public class Sparrow : Bird
    {

    }
    public class Parrot : Bird, IBasking
    {
        public void Bask()
        {
            Console.WriteLine("Chuh-Chuh-Chuh...");
        }

        public override void Eat()
        {
            Console.WriteLine("Oh! My seeds and fruits!");
        }
        public override void Krya()
        {
            Console.WriteLine("Krya-Krya-Krya...");
        }
        public override void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
}
