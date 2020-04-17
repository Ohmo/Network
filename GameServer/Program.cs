using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.Start(50, 26950);

            Console.ReadLine();
        }
    }
}
