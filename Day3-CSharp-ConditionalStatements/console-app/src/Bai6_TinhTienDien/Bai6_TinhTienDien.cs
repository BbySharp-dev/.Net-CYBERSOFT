namespace CSharp_BaiTap.Bai6_TinhTienDien
{
    /// <summary>
    /// Bài 6: Tính tiền điện
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào số kWh tiêu thụ và sử dụng if...else if...else để tính tiền điện theo biểu giá sau:
    /// - Dưới 100 kWh: 1.500 VND/kWh
    /// - Từ 100 đến 200 kWh: 2.000 VND/kWh
    /// - Trên 200 kWh: 2.500 VND/kWh
    /// </remarks>
    public class Bai6_TinhTienDien
    {
        public static void Run()
        {
            Console.WriteLine("Nhập số kWh tiêu thụ: ");

            if (!double.TryParse(Console.ReadLine(), out double kWh) || kWh < 0)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số kWh hợp lệ (>= 0).");
                return;
            }

            double tienDien;

            if (kWh <= 100)
            {
                tienDien = kWh * 1500;
            }
            else if (kWh <= 200)
            {
                tienDien = kWh * 2000;
            }
            else
            {
                tienDien = kWh * 2500;
            }

            Console.WriteLine($"Tiền điện cần thanh toán: {tienDien} VND");
        }
    }
}
