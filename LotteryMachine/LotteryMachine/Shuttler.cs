using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace LotteryMachine
{
    class LotteryMachine
    {
        private static int _maxAmountOfBalls = 100000;


        public static void ProduceIEDic(int h )
        {
            object[] f = new object[]
            {
                new TextBox(),
                new Button()
            };

            object k = "kkk";
            string g = "kkk";

            var n = "k";
       

        }

        // 洗球
        public static int[] Shuttler()
        {
            int[] list = new int[GetMaxNumber()];
            
            for (int a = 0; a < GetMaxNumber(); a++)
            {
                list[a] = a + 1; // 將值放到陣列中
            }
            
            for (int a = 0; a < GetMaxNumber(); a++)
            {
                

                int num = GetOneNumber(GetMaxNumber()); // 取要作為交換值的數字
                // 交換: A -> C, B -> A, C -> B
                int temp = list[a]; // 設定一暫時的變數存取要被交換的值
                list[a] = list[num];
                list[num] = temp;
            }

            return list;
        }

        // 取得最大值
        public static int GetMaxNumber()
        {
            return _maxAmountOfBalls;
        }

        // 亂數取一個數字 回傳給呼叫的程式
        public static int GetOneNumber(int number)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(1, number);
            
            return i;
        }
    }
}
