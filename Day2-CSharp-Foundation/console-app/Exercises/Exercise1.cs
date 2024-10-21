namespace console_app.Exercises
{
    public class Exercise1
    {
        /// <summary>
        /// Tính số ngày trong tuần và số ngày lẻ.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại.
        /// </remarks>
        /// <example>
        /// Ví dụ: Người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày.
        /// </example>
        /// <param name="days">Số ngày mà người dùng nhập vào.</param>
        /// <returns>Trả về số tuần và số ngày lẻ còn lại.</returns>

        public void Run()
        {
            Console.Write("Nhập số ngày cần tính: ");
            string? daysInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(daysInput) || !int.TryParse(daysInput, out int days))
            {
                Console.WriteLine("Lỗi: Giá trị nhập vào không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (days < 0)
            {
                Console.WriteLine("Lỗi: Số ngày không được nhỏ hơn 0. Vui lòng nhập số ngày hợp lệ.");
                return;
            }

            int soTuan = days / 7;
            int soNgayLe = days % 7;

            Console.WriteLine($"Kết quả: {soTuan} tuần và {soNgayLe} ngày lẻ.");
        }
    }
}
