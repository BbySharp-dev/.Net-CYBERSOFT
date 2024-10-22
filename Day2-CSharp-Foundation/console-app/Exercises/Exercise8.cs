namespace console_app.Exercises
{
    public class Exercise8
    {
        /// <summary>
        /// Tính tỷ lệ phần trăm của một số trong tổng số.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập một số và một tổng số.
        /// </remarks>
        /// <example>
        /// Ví dụ: Số là 20 và tổng số là 100, tỷ lệ phần trăm là 20%.
        /// </example>
        /// <param name="number">Số mà người dùng nhập vào.</param>
        /// <param name="total">Tổng số mà người dùng nhập vào.</param>
        /// <returns>Tỷ lệ phần trăm của số đó trong tổng số.</returns>

        public void Run()
        {
            Console.Write("Nhập số: ");
            string? numberInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numberInput) || !decimal.TryParse(numberInput, out decimal number))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số hợp lệ.");
                return;
            }

            Console.Write("Nhập tổng số: ");
            string? totalInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(totalInput) || !decimal.TryParse(totalInput, out decimal total))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập tổng số hợp lệ.");
                return;
            }

            if (number < 0 || total <= 0)
            {
                Console.WriteLine("Lỗi: Số và tổng số không thể âm và tổng số phải lớn hơn 0.");
                return;
            }

            decimal percentage = (number / total) * 100;

            Console.WriteLine($"Tỷ lệ phần trăm của {number} trong {total} là {percentage:N2}%.");
        }
    }
}
