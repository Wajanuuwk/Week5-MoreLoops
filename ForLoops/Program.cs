using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis
            //"I will not skateboard in the hall"
            //10 korda

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}I will not skateboard in the hall");
            }
        }
    }
}
