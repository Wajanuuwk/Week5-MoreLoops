using System;

namespace OneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis arve 1 kuni 100
            //kasutame for-loop'i
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
    }
}
