namespace CSharp_BaiTap.Bai5_KiemTraSoNguyenTo
{
    /// <summary>
    /// Bài 5: Kiểm tra số nguyên tố
    /// </summary>
    /// <remarks>
    /// Viết chương trình nhận vào một số nguyên và sử dụng if...else để kiểm tra xem số đó có phải là số nguyên tố hay không.
    /// </remarks>
    public class Bai5_KiemTraSoNguyenTo
    {
        public static void Run()
        {
            Console.WriteLine("Nhập số nguyên >= 2: ");

            if (!int.TryParse(Console.ReadLine(), out int so) || so < 2)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên >= 2.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"Số {so} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"Số {so} không phải là số nguyên tố.");
            }
        }
    }
}
