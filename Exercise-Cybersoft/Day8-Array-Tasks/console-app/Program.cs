using System;

class Program
{
    static void Main()
    {
        try
        {
            while (true)
            {
                Console.WriteLine("\n=== Array Tasks Menu ===");
                Console.WriteLine("1. Sum Array (Bài 1)");
                Console.WriteLine("2. Two Sum (Bài 2)");
                Console.WriteLine("3. Remove Duplicates (Bài 3)");
                Console.WriteLine("4. Top K Frequent (Bài 4)");
                Console.WriteLine("5. Buy and Sell Stock (Bài 5)");
                Console.WriteLine("0. Exit");
                Console.Write("Chọn bài cần chạy (1-5) hoặc 0 để thoát: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Bai1_SumArray.Run();
                        break;
                    case "2":
                        Bai2_TwoSum.Run();
                        break;
                    case "3":
                        Bai3_RemoveDuplicates.Run();
                        break;
                    case "4":
                        Bai4_TopKFrequent.Run();
                        break;
                    case "5":
                        Bai5_BuySellStock.Run();
                        break;
                    case "0":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("An error occurred during execution.");
        }
    }
}
