namespace CSharp_BaiTap.Bai3_XacDinhMuaTrongNam
{
    /// <summary>
    /// Bài 3: Xác định mùa trong năm
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào số từ 1 đến 12 tương ứng với các tháng trong năm và sử dụng switch expression để xác định mùa.
    /// Xuân: Tháng 3 đến tháng 5
    /// Hạ: Tháng 6 đến tháng 8
    /// Thu: Tháng 9 đến tháng 11
    /// Đông: Tháng 12 đến tháng 2
    /// </remarks>
    public class Bai3_XacDinhMuaTrongNam
    {
        public static void Run()
        {
            Console.WriteLine("Nhập tháng (1-12): ");

            if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập tháng hợp lệ (1-12).");
                return;
            }

            string season = month switch
            {
                12 or 1 or 2 => "Mùa Đông",
                3 or 4 or 5 => "Mùa Xuân",
                6 or 7 or 8 => "Mùa Hè",
                9 or 10 or 11 => "Mùa Thu",
                _ => "Tháng không hợp lệ"
            };

            Console.WriteLine($"Tháng {month} là {season}.");
        }
    }
}
