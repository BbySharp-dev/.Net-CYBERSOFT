namespace console_app.Exercises
{
    public class Exercise3
    {
        /// <summary>
        /// Chuyển đổi thời gian từ phút sang giờ và phút.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập vào số phút và chuyển đổi thành giờ và phút.
        /// </remarks>
        /// <example>
        /// Ví dụ: Người dùng nhập 130 phút, kết quả là 2 giờ 10 phút.
        /// </example>
        /// <param name="minutes">Số phút mà người dùng nhập vào.</param>
        /// <returns>Số giờ và số phút sau khi chuyển đổi.</returns>
        public void Run()
        {
            Console.Write("Nhập số phút: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int minutes))
            {
                Console.WriteLine("Vui lòng nhập số phút hợp lệ (số nguyên dương) và không để trống.");
                return;
            }

            if (minutes < 0)
            {
                Console.WriteLine("Vui lòng nhập số phút là số nguyên dương.");
                return;
            }

            int soGio = minutes / 60;
            int soPhutConLai = minutes % 60;

            Console.WriteLine($"Kết quả: {soGio} giờ {soPhutConLai} phút.");
        }
    }
}
