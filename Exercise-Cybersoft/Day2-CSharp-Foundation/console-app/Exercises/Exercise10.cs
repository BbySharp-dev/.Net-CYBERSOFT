namespace console_app.Exercises
{
    public class Exercise10
    {
        /// <summary>
        /// Tính lượng calo tiêu thụ dựa trên số phút tập thể dục và loại hình tập thể dục.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập số phút đã tập thể dục và chọn loại hình tập thể dục.
        /// </remarks>
        /// <example>
        /// Ví dụ: Người dùng đã chạy 30 phút, lượng calo tiêu thụ sẽ được tính toán dựa trên hệ số cho hoạt động chạy.
        /// </example>
        /// <param name="exerciseMinutes">Số phút đã tập thể dục.</param>
        /// <param name="exerciseType">Loại hình tập thể dục (chạy, đạp xe, bơi lội, ...).</param>
        /// <returns>Lượng calo tiêu thụ.</returns>

        public void Run()
        {
            Console.Write("Nhập số phút tập thể dục: ");
            string? minutesInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(minutesInput) || !int.TryParse(minutesInput, out int exerciseMinutes))
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số phút hợp lệ.");
                return;
            }

            if (exerciseMinutes <= 0)
            {
                Console.WriteLine("Lỗi: Số phút phải lớn hơn 0.");
                return;
            }

            Console.WriteLine("Chọn loại hình tập thể dục: (1) Chạy, (2) Đạp xe, (3) Bơi lội");
            string? exerciseTypeInput = Console.ReadLine();

            decimal calorieRate;

            switch (exerciseTypeInput)
            {
                case "1":
                    calorieRate = 10;
                    break;
                case "2":
                    calorieRate = 8;
                    break;
                case "3":
                    calorieRate = 7;
                    break;
                default:
                    Console.WriteLine("Lỗi: Loại hình tập thể dục không hợp lệ.");
                    return;
            }

            decimal caloriesBurned = exerciseMinutes * calorieRate;

            Console.WriteLine($"Lượng calo tiêu thụ sau {exerciseMinutes} phút là {caloriesBurned:N2} calo.");
        }
    }
}
