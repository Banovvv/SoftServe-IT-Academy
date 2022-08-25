using System;

namespace SoftServe.Practice._Inheritance._Polymorphism
{
    public class Science
    {
        public virtual void Awards()
        {
            Console.WriteLine("We can obtain The Nobel Prize");
        }
    }

    public class Physics : Science
    {

    }

    public class Mathematics : Science
    {
        public override void Awards()
        {
            Console.WriteLine("We don't need any awards, but we still can obtain The Abel Prize that nobody else can!");
        }
    }
}
