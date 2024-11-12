namespace CSharp_BaiTap.Bai2_TinhThue
{
    /// <summary>
    /// Bài 2: Tính thuế thu nhập cá nhân
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào thu nhập của một cá nhân và sử dụng if...else if...else để tính thuế dựa trên các mức thuế suất:
    /// - Thu nhập <= 5 triệu: Miễn thuế
    /// - Thu nhập <= 10 triệu: Thuế 10%
    /// - Thu nhập > 10 triệu: Thuế 20%
    /// </remarks>
    public class Bai2_TinhThue
    {
        public static void Run()
        {
            Console.WriteLine("Nhập thu nhập của bạn (triệu VND): ");

            if (!double.TryParse(Console.ReadLine(), out double thuNhap) || thuNhap < 0)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một giá trị hợp lệ cho thu nhập (>= 0).");
                return;
            }

            double thue;

            if (thuNhap <= 5)
            {
                thue = 0;
            }
            else if (thuNhap <= 10)
            {
                thue = thuNhap * 0.1;
            }
            else
            {
                thue = thuNhap * 0.2;
            }

            Console.WriteLine($"Thuế phải nộp: {thue} triệu VND");
        }
    }
}
