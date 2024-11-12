namespace console_app.Exercises
{
    public class Exercise4
    {
        /// <summary>
        /// Tính tổng số tiền sau khi cộng thêm thuế VAT.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập số tiền gốc và tỷ lệ thuế VAT.
        /// </remarks>
        /// <example>
        /// Ví dụ: Nếu số tiền gốc là 1000 và thuế VAT là 10%, tổng số tiền sẽ là 1100.
        /// </example>
        /// <param name="soTienGoc">Số tiền gốc.</param>
        /// <param name="thueVAT">Tỷ lệ thuế VAT.</param>
        /// <returns>Tổng số tiền sau khi cộng thêm thuế VAT.</returns>
        public void Run()
        {
            Console.Write("Nhập số tiền gốc: ");
            string? soTienGocInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(soTienGocInput) || !decimal.TryParse(soTienGocInput, out decimal soTienGoc))
            {
                Console.WriteLine("Lỗi: Giá trị nhập vào không hợp lệ. Vui lòng nhập số tiền hợp lệ.");
                return;
            }

            Console.Write("Nhập tỷ lệ thuế VAT (%): ");
            string? thueVATInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(thueVATInput) || !decimal.TryParse(thueVATInput, out decimal thueVAT))
            {
                Console.WriteLine("Lỗi: Giá trị nhập vào không hợp lệ. Vui lòng nhập tỷ lệ thuế hợp lệ.");
                return;
            }

            if (thueVAT < 0)
            {
                Console.WriteLine("Lỗi: Tỷ lệ thuế VAT không được nhỏ hơn 0. Vui lòng nhập giá trị hợp lệ.");
                return;
            }

            decimal vatAmount = soTienGoc * (thueVAT / 100);
            decimal totalAmount = soTienGoc + vatAmount;

            Console.WriteLine($"Số tiền sau khi cộng thêm thuế VAT: {totalAmount} (VNĐ)");
        }
    }
}
