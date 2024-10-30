using System;

public class Bai3_RemoveDuplicates
{
    public static void Run()
    {
        int[] nums = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        int length = RemoveDuplicates(nums);
        Console.WriteLine("Bài 3 - Chiều dài mảng sau khi loại bỏ phần tử trùng lặp: " + length);
    }

    static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int uniqueIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[uniqueIndex] = nums[i];
                uniqueIndex++;
            }
        }
        return uniqueIndex;
    }
}
