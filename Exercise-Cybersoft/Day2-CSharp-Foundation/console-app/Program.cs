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
            Console.Write("\nChọn bài tập để thực hiện (1-10):");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nBài tập 1: Tính số tuần và số ngày lẻ");
                    var exercise1 = new Exercise1();
                    exercise1.Run();
                    break;
                case 2:
                    Console.WriteLine("\nBài tập 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá");
                    var exercise2 = new Exercise2();
                    exercise2.Run();
                    break;
                case 3:
                    Console.WriteLine("\nBài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút");
                    var exercise3 = new Exercise3();
                    exercise3.Run();
                    break;
                case 4:
                    Console.WriteLine("\nBài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT");
                    var exercise4 = new Exercise4();
                    exercise4.Run();
                    break;
                case 5:
                    Console.WriteLine("\nBài tập 5: Chuyển đổi đơn vị tiền tệ");
                    var exercise5 = new Exercise5();
                    exercise5.Run();
                    break;
                case 6:
                    Console.WriteLine("\nBài tập 6: Tính số dư sau khi rút tiền từ tài khoản");
                    var exercise6 = new Exercise6();
                    exercise6.Run();
                    break;
                case 7:
                    Console.WriteLine("\nBài tập 7: Tính tốc độ trung bình");
                    var exercise7 = new Exercise7();
                    exercise7.Run();
                    break;
                case 8:
                    Console.WriteLine("\nBài tập 8: Tính tỷ lệ phần trăm");
                    var exercise8 = new Exercise8();
                    exercise8.Run();
                    break;
                case 9:
                    Console.WriteLine("\nBài tập 9: Chuyển đổi từ km/h sang m/s");
                    var exercise9 = new Exercise9();
                    exercise9.Run();
                    break;
                case 10:
                    Console.WriteLine("\nBài tập 10: Tính lượng calo tiêu thụ");
                    var exercise10 = new Exercise10();
                    exercise10.Run();
                    break;
                default:
                    Console.WriteLine("Bài tập không hợp lệ! Vui lòng chọn từ 1-10.");
                    break;
            }
        }
    }
}
