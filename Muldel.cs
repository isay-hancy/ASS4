using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace ASS4
{
    public delegate void mDel(string message);
    internal class Muldel
    {
        static void Main(string[] args)
        {
            mDel del = Welcome;
            del += Hi;
            del += Hello;
            del("JOHN");

        }
        static void Welcome(string message)
        {
            Console.WriteLine("welcome" + message);
        }
        static void Hi(string message)
        {
            Console.WriteLine($"Hi {message}");
        }
        static void Hello(string message)
        {
            Console.WriteLine("Hello" + message);
        }
    }
}
