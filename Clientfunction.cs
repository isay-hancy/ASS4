namespace ASS4
{
    public delegate void msgDel(string msg);
    internal class Clientfunction
    {
        static void Main(string[] args)
        {
            Welcome("Aisha");
        }
        static void Welcome(string msg)
        {
            Console.WriteLine("welcome" + msg);
        }
    }
}
