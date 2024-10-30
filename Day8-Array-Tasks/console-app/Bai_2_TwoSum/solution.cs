using System;

public class Bai2_TwoSum
{
    public static void Run()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = FindTwoSum(nums, target);
        if (result.Length == 2)
            Console.WriteLine($"Bài 2 - Hai số có tổng bằng {target}: [{result[0]}, {result[1]}]");
        else
            Console.WriteLine("Bài 2 - Không tìm thấy cặp số nào.");
    }

    static int[] FindTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return Array.Empty<int>();
    }
}
