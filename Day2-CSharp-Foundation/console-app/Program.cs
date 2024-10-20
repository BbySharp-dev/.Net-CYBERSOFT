using console_app.Exercises;

namespace console_app
{
    class ExerciseProgram
    {
        static void Main()
        {
            Console.WriteLine("\n1. Tính số tuần và số ngày lẻ");
            Console.WriteLine("\n2. Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá");
            Console.WriteLine("\n3. Chuyển đổi thời gian từ phút sang giờ và phút");
            Console.WriteLine("\n4. Tính tổng số tiền sau khi cộng thêm thuế VAT");
            Console.WriteLine("\n5. Chuyển đổi đơn vị tiền tệ");
            Console.WriteLine("\n6. Tính số dư sau khi rút tiền từ tài khoản");
            Console.WriteLine("\n7. Tính tốc độ trung bình");
            Console.WriteLine("\n8. Tính tỷ lệ phần trăm");
            Console.WriteLine("\n9. Chuyển đổi từ km/h sang m/s");
            Console.WriteLine("\n10. Tính lượng calo tiêu thụ");
            Console.WriteLine("\nChọn bài tập để thực hiện (1-10):");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nBài tập 1: Tính số tuần và số ngày lẻ");
                    break;
                case 2:
                    Console.WriteLine("\nBài tập 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá");
                    break;
                case 3:
                    Console.WriteLine("\nBài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút");
                    break;
                case 4:
                    Console.WriteLine("\nBài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT");
                    break;
                case 5:
                    Console.WriteLine("\nBài tập 5: Chuyển đổi đơn vị tiền tệ");
                    break;
                case 6:
                    Console.WriteLine("\nBài tập 6: Tính số dư sau khi rút tiền từ tài khoản");
                    break;
                case 7:
                    Console.WriteLine("\nBài tập 7: Tính tốc độ trung bình");
                    break;
                case 8:
                    Console.WriteLine("\nBài tập 8: Tính tỷ lệ phần trăm");
                    break;
                case 9:
                    Console.WriteLine("\nBài tập 9: Chuyển đổi từ km/h sang m/s");
                    break;
                case 10:
                    Console.WriteLine("\nBài tập 10: Tính lượng calo tiêu thụ");
                    break;
                default:
                    Console.WriteLine("Bài tập không hợp lệ! Vui lòng chọn từ 1-10.");
                    break;
            }
        }
    }
}
