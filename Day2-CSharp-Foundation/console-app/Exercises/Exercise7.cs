namespace console_app.Exercises
{
    public class Exercise7
    {
        /// <summary>
        /// Tính tốc độ trung bình dựa trên quãng đường và thời gian.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập quãng đường đã đi và thời gian đã đi.
        /// </remarks>
        /// <example>
        /// Ví dụ: Quãng đường là 100 km và thời gian là 2 giờ, tốc độ trung bình là 50 km/h.
        /// </example>
        /// <param name="distance">Quãng đường đã đi (km).</param>
        /// <param name="time">Thời gian đã đi (giờ).</param>
        /// <returns>Tốc độ trung bình (km/h).</returns>

        public void Run()
        {
            Console.Write("Nhập quãng đường đã đi (km): ");
            string? distanceInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(distanceInput) || !decimal.TryParse(distanceInput, out decimal distance))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập quãng đường hợp lệ.");
                return;
            }

            Console.Write("Nhập thời gian đã đi (giờ): ");
            string? timeInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(timeInput) || !decimal.TryParse(timeInput, out decimal time))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập thời gian hợp lệ.");
                return;
            }

            if (distance < 0)
            {
                Console.WriteLine("Lỗi: Quãng đường không thể nhỏ hơn 0.");
                return;
            }

            if (time <= 0)
            {
                Console.WriteLine("Lỗi: Thời gian phải lớn hơn 0.");
                return;
            }

            decimal averageSpeed = distance / time;

            Console.WriteLine($"Tốc độ trung bình của bạn là {averageSpeed:N2} km/h.");
        }
    }
}
