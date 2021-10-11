﻿using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber = 23;
            int integerNumber = -23;
            float realNumber = 2.3F;
            double anotherRealNumber = 2.3;

            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_000;
             int hexadecimalNotation = 0x_001E_8480;

            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
        }
    }
}
