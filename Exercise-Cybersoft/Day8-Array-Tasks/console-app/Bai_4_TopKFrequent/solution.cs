using System;
using System.Collections.Generic;
using System.Linq;

public class Bai4_TopKFrequent
{
    public static void Run()
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        List<int> result = TopKFrequent(nums, k);
        Console.WriteLine("Bài 4 - Phần tử xuất hiện nhiều nhất trong mảng: [" + string.Join(", ", result) + "]");
    }

    static List<int> TopKFrequent(int[] nums, int k)
    {
        var frequency = new Dictionary<int, int>();
        foreach (int num in nums)
            frequency[num] = frequency.ContainsKey(num) ? frequency[num] + 1 : 1;

        return frequency.OrderByDescending(x => x.Value)
                        .Take(k)
                        .Select(x => x.Key)
                        .ToList();
    }
}
