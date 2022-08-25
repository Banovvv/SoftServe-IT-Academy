using System;

namespace SoftServe_IT_Academy.Practice._Delegates__Events
{
    public class EventProgram
    {
        public delegate void EventHandler();
        public event EventHandler Show;

        void Dog() => Console.WriteLine("Dog");
        void Cat() => Console.WriteLine("Cat");
        void Mouse() => Console.WriteLine("Mouse");
        void Elephant() => Console.WriteLine("Elephant");

        public EventProgram()
        {
            Show += Dog;
            Show += Cat;
            Show += Mouse;
            Show += Elephant;
            Show.Invoke();
        }
    }
}
