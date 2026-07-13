using System;
using System.Collections.Generic;
using System.Text;

namespace ASS4
{
    public delegate void msgDel(string msg);
    internal class Cldelfun
    {
        static void Main(string[] args)
        {
            msgDel del = Welcome;
            del("Aisha");
        }
        static void Welcome(string msg)
        {
            Console.WriteLine("welcome" + msg);
        }
    }
}
