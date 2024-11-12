namespace CSharp_BaiTap.Bai4_KiemTraTuoi
{
    /// <summary>
    /// Bài 4: Kiểm tra tuổi và phân loại
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào tuổi của một người và sử dụng if...else để xác định người đó thuộc nhóm nào:
    /// - Dưới 18 tuổi: Trẻ em
    /// - Từ 18 đến 60 tuổi: Người lớn
    /// - Trên 60 tuổi: Người cao tuổi
    /// </remarks>
    public class Bai4_KiemTraTuoi
    {
        public static void Run()
        {
            Console.WriteLine("Nhập tuổi của bạn: ");

            if (!int.TryParse(Console.ReadLine(), out int tuoi) || tuoi < 0)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập tuổi hợp lệ (>= 0).");
                return;
            }

            if (tuoi < 18)
            {
                Console.WriteLine("Bạn là trẻ em.");
            }
            else if (tuoi <= 60)
            {
                Console.WriteLine("Bạn là người lớn.");
            }
            else
            {
                Console.WriteLine("Bạn là người cao tuổi.");
            }
        }
    }
}
