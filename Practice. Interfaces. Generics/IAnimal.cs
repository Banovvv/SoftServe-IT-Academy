using System;

namespace SoftServe_IT_Academy.Practice._Interfaces._Generics
{
    public interface IAnimal
    {
        string Name { get; set; }
        void Voice();
        void Feed();
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public void Voice() => Console.WriteLine("Mew");
        public void Feed() => Console.WriteLine("I eat mice");
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public void Voice() => Console.WriteLine("Woof");
        public void Feed() => Console.WriteLine("I eat meat");
    }
}
