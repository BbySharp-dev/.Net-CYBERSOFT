namespace CSharp_BaiTap.Bai7_XacDinhHangVe
{
    /// <summary>
    /// Bài 7: Xác định hạng vé xem phim
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào hạng vé xem phim (Standard, Premium, VIP) và sử dụng switch expression để in ra các tiện ích tương ứng với hạng vé đó.
    /// - Standard: Ghế ngồi thường, không có đồ uống
    /// - Premium: Ghế ngồi thoải mái, có đồ uống miễn phí
    /// - VIP: Ghế ngồi hạng sang, có đồ uống và bắp rang miễn phí
    /// </remarks>
    public class Bai7_XacDinhHangVe
    {
        public static void Run()
        {
            Console.WriteLine("Nhập hạng vé (Standard, Premium, VIP): ");
            string hangVe = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(hangVe))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập hạng vé hợp lệ.");
                return;
            }

            switch (hangVe.ToLower())
            {
                case "standard":
                    Console.WriteLine("Ghế ngồi thường, không có đồ uống.");
                    break;
                case "premium":
                    Console.WriteLine("Ghế ngồi thoải mái, có đồ uống miễn phí.");
                    break;
                case "vip":
                    Console.WriteLine("Ghế ngồi hạng sang, có đồ uống và bắp rang miễn phí.");
                    break;
                default:
                    Console.WriteLine("Hạng vé không hợp lệ.");
                    break;
            }
        }
    }
}
