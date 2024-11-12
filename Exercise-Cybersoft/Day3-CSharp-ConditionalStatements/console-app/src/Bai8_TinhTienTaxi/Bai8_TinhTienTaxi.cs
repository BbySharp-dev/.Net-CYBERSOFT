namespace CSharp_BaiTap.Bai8_TinhTienTaxi
{
    /// <summary>
    /// Bài 8: Tính tiền taxi
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào số km mà khách hàng đã đi và sử dụng if...else để tính tiền taxi theo biểu giá sau:
    /// - 1 km đầu tiên: 10.000 VND
    /// - Từ km thứ 2 đến km thứ 5: 8.000 VND/km
    /// - Trên 5 km: 6.000 VND/km
    /// </remarks>
    public class Bai8_TinhTienTaxi
    {
        public static void Run()
        {
            Console.WriteLine("Nhập số km đã đi: ");

            if (!double.TryParse(Console.ReadLine(), out double soKm) || soKm < 0)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số km hợp lệ.");
                return;
            }

            double tienTaxi;

            if (soKm <= 1)
            {
                tienTaxi = 10000;
            }
            else if (soKm <= 5)
            {
                tienTaxi = 10000 + (soKm - 1) * 8000;
            }
            else
            {
                tienTaxi = 10000 + 4 * 8000 + (soKm - 5) * 6000;
            }

            Console.WriteLine($"Tiền taxi cần thanh toán: {tienTaxi} VND");
        }
    }
}
