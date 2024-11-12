namespace console_app.Exercises
{
    public class Exercise5
    {
        /// <summary>
        /// Chuyển đổi đơn vị tiền tệ từ USD sang VND.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập số tiền bằng USD và tỷ giá chuyển đổi.
        /// </remarks>
        /// <example>
        /// Ví dụ: Người dùng nhập 100 USD với tỷ giá 23000 VND/USD, kết quả sẽ là 2,300,000 VND.
        /// </example>
        /// <param name="soTienUSD">Số tiền bằng USD.</param>
        /// <param name="tyGiaChuyenDoi">Tỷ giá chuyển đổi từ USD sang VND.</param>
        /// <returns>Số tiền sau khi chuyển đổi sang VND.</returns>
        public void Run()
        {
            Console.Write("Nhập số tiền USD: ");
            string? soTienUSDInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(soTienUSDInput) || !decimal.TryParse(soTienUSDInput, out decimal soTienUSD))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số tiền USD hợp lệ.");
                return;
            }

            Console.Write("Nhập tỷ giá chuyển đổi (VND/USD): ");
            string? tyGiaChuyenDoiInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tyGiaChuyenDoiInput) || !decimal.TryParse(tyGiaChuyenDoiInput, out decimal tyGiaChuyenDoi))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập tỷ giá chuyển đổi hợp lệ.");
                return;
            }

            if (soTienUSD < 0 || tyGiaChuyenDoi < 0)
            {
                Console.WriteLine("Lỗi: Số tiền và tỷ giá không thể nhỏ hơn 0.");
                return;
            }

            decimal convertedAmount = soTienUSD * tyGiaChuyenDoi;
            Console.WriteLine($"Số tiền sau khi chuyển đổi: {convertedAmount:N0} VND");
        }
    }
}
