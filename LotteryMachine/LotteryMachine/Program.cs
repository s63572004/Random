using System;
using System.Windows.Forms;

namespace LotteryMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var numbers in LotteryMachine.Shuttler())
            {
                object[] f = new object[]
         {
                new TextBox(),
                new Button()
         };
              
                var v3 = f[0] as Button;
                v3 = v3;
                v3 = f[1] as Button;
                v3 = v3;

                Console.Write(numbers + " ");
            }
        }
    }
}
