using System;

namespace ASS4
{
    // Delegate
    public delegate void MyEventHandler();

    class EventDemo
    {
        // Event declaration
        public event MyEventHandler MyEvent;

        // Method to raise the event
        public void RaiseEvent()
        {
            Console.WriteLine("Event is raised.");
            MyEvent?.Invoke();
        }
    }

    class Program
    {
        // Event handler
        static void ShowMessage()
        {
            Console.WriteLine("Event handled successfully!");
        }

        static void Main(string[] args)
        {
            EventDemo obj = new EventDemo();

            // Subscribe to the event
            obj.MyEvent += ShowMessage;

            // Raise the event
            obj.RaiseEvent();

            Console.ReadKey();
        }
    }
}