using System;

public class Bai1_SumArray
{
    public static void Run()
    {
        int[] IstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        int sum = 0;
        foreach (int num in IstNumber)
            sum += num;
        Console.WriteLine("Bài 1 - Tổng các phần tử trong mảng: " + sum);
    }
}
