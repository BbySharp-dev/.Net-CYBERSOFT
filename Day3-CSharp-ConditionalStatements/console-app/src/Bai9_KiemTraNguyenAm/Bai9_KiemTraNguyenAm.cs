namespace CSharp_BaiTap.Bai9_KiemTraNguyenAm
{
    /// <summary>
    /// Bài 9: Kiểm tra ký tự nguyên âm hay phụ âm
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào một ký tự và sử dụng switch expression để kiểm tra xem ký tự đó là nguyên âm (a, e, i, o, u) hay phụ âm.
    /// </remarks>
    public class Bai9_KiemTraNguyenAm
    {
        public static void Run()
        {
            Console.WriteLine("Nhập một ký tự: ");
            char kyTu = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (!char.IsLetter(kyTu))
            {
                // Thông báo lỗi nếu ký tự nhập không phải là chữ cái
                Console.WriteLine("Lỗi: Vui lòng nhập một ký tự chữ cái.");
                return;
            }

            string loaiKyTu = kyTu switch
            {
                'a' or 'e' or 'i' or 'o' or 'u' => "Nguyên âm",
                'A' or 'E' or 'I' or 'O' or 'U' => "Nguyên âm",
                _ => "Phụ âm"
            };

            Console.WriteLine($"Ký tự {kyTu} là {loaiKyTu}.");
        }
    }
}
