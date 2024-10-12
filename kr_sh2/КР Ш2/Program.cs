﻿using System;
using System.Text;
using System.Windows.Markup;

public class Program
{
    public static string NumToRom(int number)
    {
        if (number < 0 || number > 3000)
            throw new ArgumentException("...");

        if (number == 0) return "N";
            
        int[] value = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] num = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        StringBuilder result = new StringBuilder();

        for(int i = 0; i < 13; i++)
        {
            while (number >= value[i])
            {
                number -= value[i];
                result.Append(num[i]);
            }
        }
        return result.ToString();
    }

    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(NumToRom(num));
    }

    
}



