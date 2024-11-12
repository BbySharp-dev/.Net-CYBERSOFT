namespace CSharp_BaiTap.Bai10_XacDinhLoaiMayBay
{
    /// <summary>
    /// Bài 10: Xác định loại vé máy bay
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào loại vé máy bay (Economy, Business, First Class) và sử dụng switch expression để in ra các tiện ích tương ứng với loại vé đó.
    /// </remarks>
    public class Bai10_XacDinhLoaiMayBay
    {
        public static void Run()
        {
            Console.WriteLine("Nhập loại vé (Economy, Business, FirstClass): ");
            string loaiVe = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(loaiVe))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập loại vé hợp lệ.");
                return;
            }

            switch (loaiVe.ToLower())
            {
                case "economy":
                    Console.WriteLine("Ghế thường, không có đồ uống miễn phí.");
                    break;
                case "business":
                    Console.WriteLine("Ghế hạng thương gia, có đồ uống miễn phí.");
                    break;
                case "firstclass":
                    Console.WriteLine("Ghế hạng nhất, có đồ uống và bữa ăn miễn phí.");
                    break;
                default:
                    Console.WriteLine("Loại vé không hợp lệ.");
                    break;
            }
        }
    }
}
