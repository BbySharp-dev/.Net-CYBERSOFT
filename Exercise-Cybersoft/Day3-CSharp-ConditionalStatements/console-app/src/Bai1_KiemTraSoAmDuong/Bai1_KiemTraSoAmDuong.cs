namespace CSharp_BaiTap.Bai1_KiemTraSoAmDuong
{
    /// <summary>
    /// Bài 1: Kiểm tra số âm, dương hoặc bằng 0
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào một số nguyên và kiểm tra xem số đó là số âm, dương hay bằng 0.
    /// Sử dụng câu lệnh if...else để xác định và in kết quả ra màn hình.
    /// </remarks>
    public class Bai1_KiemTraSoAmDuong
    {
        public static void Run()
        {
            Console.WriteLine("Nhập vào số nguyên: ");

            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
                return;
            }

            if (value < 0)
            {
                Console.WriteLine($"Số {value} là số âm.");
            }
            else if (value > 0)
            {
                Console.WriteLine($"Số {value} là số dương.");
            }
            else
            {
                Console.WriteLine("Số = 0.");
            }
        }
    }
}
