﻿using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            // throw new NotImplementedException();
            if (count <= 0)
            {
                throw new ArgumentException();
            }
           int sum = 0;
           for (int i=0; i< count; i++)
            {
                try
                    { sum += number + i * add;}
                catch (OverflowException)
                {
                    throw new OverflowException();
                }
            }
            return sum;
        }
    }
}
