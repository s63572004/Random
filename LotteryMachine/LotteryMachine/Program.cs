using System;

namespace LotteryMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var numbers in LotteryMachine.Shuttler())
            {
                Console.Write(numbers + " ");
            }
        }
    }
}
