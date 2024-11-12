namespace console_app.Exercises
{
    public class Exercise6
    {
        /// <summary>
        /// Tính số dư còn lại sau khi rút tiền từ tài khoản.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập số dư tài khoản và số tiền muốn rút.
        /// </remarks>
        /// <example>
        /// Ví dụ: Người dùng có 5000 VND trong tài khoản và rút 2000 VND, kết quả còn lại là 3000 VND.
        /// </example>
        /// <param name="soDuTaiKhoan">Số dư hiện tại của tài khoản.</param>
        /// <param name="soTien">Số tiền muốn rút.</param>
        /// <returns>Số dư còn lại sau khi rút tiền.</returns>

        public void Run()
        {
            Console.WriteLine("Nhập số dư tài khoản của bạn (VND):");
            string? soDuTaiKhoanInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(soDuTaiKhoanInput) || !decimal.TryParse(soDuTaiKhoanInput, out decimal soDuTaiKhoan))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số tiền VND hợp lệ.");
                return;
            }

            Console.WriteLine("Nhập số tiền bạn muốn rút (VND):");
            string? soTienInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(soTienInput) || !decimal.TryParse(soTienInput, out decimal soTien))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số tiền VND hợp lệ.");
                return;
            }

            if (soDuTaiKhoan < 0 || soTien < 0)
            {
                Console.WriteLine("Lỗi: Số tiền không thể nhỏ hơn 0.");
                return;
            }

            if (soTien > soDuTaiKhoan)
            {
                Console.WriteLine("Lỗi: Số tiền muốn rút lớn hơn số dư hiện tại.");
                return;
            }

            decimal results = soDuTaiKhoan - soTien;
            Console.WriteLine($"Số dư còn lại sau khi rút tiền là {results} VND.");
        }
    }
}
