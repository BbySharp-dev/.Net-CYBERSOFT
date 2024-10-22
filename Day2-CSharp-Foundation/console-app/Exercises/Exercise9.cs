namespace console_app.Exercises
{
    public class Exercise9
    {
        /// <summary>
        /// Chuyển đổi từ km/h sang m/s.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập vận tốc bằng km/h và chuyển đổi sang m/s.
        /// </remarks>
        /// <example>
        /// Ví dụ: Vận tốc là 36 km/h, kết quả là 10 m/s.
        /// </example>
        /// <param name="speedKmh">Vận tốc bằng km/h.</param>
        /// <returns>Vận tốc sau khi chuyển đổi sang m/s.</returns>

        public void Run()
        {
            Console.Write("Nhập vận tốc (km/h): ");
            string? speedKmhInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(speedKmhInput) || !decimal.TryParse(speedKmhInput, out decimal speedKmh))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập vận tốc hợp lệ.");
                return;
            }

            if (speedKmh < 0)
            {
                Console.WriteLine("Lỗi: Vận tốc không thể nhỏ hơn 0.");
                return;
            }

            decimal speedMs = speedKmh * 1000 / 3600;

            Console.WriteLine($"Vận tốc sau khi chuyển đổi là {speedMs:N2} m/s.");
        }
    }
}
