using System;

namespace CSharpCourse
{
    /*
    ========================================
    📘 Tổng Quan về Phương Thức (Method) trong C#
    ========================================

    🎯 Khái Niệm và Mục Đích Sử Dụng:
    - Phương thức là một tập hợp các câu lệnh cùng thực hiện một chức năng cụ thể, giúp mã dễ đọc, dễ quản lý và có thể tái sử dụng.
    - Phương thức thường thực hiện một chức năng hoặc hành động cụ thể nào đó, như đọc dữ liệu, xử lý tính toán, hoặc xuất kết quả.

    🔹 Lợi ích của phương thức:
    - Dễ dàng quản lý mã nguồn, bảo trì và mở rộng chương trình.
    - Tái sử dụng mã (giảm thiểu trùng lặp).
    - Tăng tính tổ chức và logic cho mã.

    📌 Ví dụ về các phương thức đã dùng trong C#:
    - Console.ReadLine(): Đọc dữ liệu từ bàn phím.
    - Main(): Điểm khởi đầu của chương trình.
    - Parse(): Chuyển đổi chuỗi thành kiểu dữ liệu tương ứng.
    - Split(): Tách chuỗi thành các phần tử nhỏ hơn.
    - Write() và WriteLine(): Hiển thị thông tin ra màn hình.

    🛠️ Cú pháp tổng quát của phương thức:
        <access modifier> <static> <return type> MethodName(params) {
            // statements
        }

    - `<access modifier>`: Quyền truy cập như public, private, protected, internal.
    - `<static>`: Quy định phương thức có tĩnh không (gọi mà không cần tạo đối tượng).
    - `<return type>`: Kiểu dữ liệu phương thức trả về, hoặc void nếu không trả về giá trị.
    - `MethodName`: Tên phương thức, thường là động từ hoặc cụm động từ biểu thị chức năng.
    - `params`: Các tham số truyền vào (có thể có 0, 1 hoặc nhiều tham số).
    
    🔹 Tham số và Đối số:
    - Tham số (parameters): Biến trong phương thức, khai báo trong ngoặc `()`.
    - Đối số (arguments): Giá trị được truyền vào phương thức khi gọi.
    
    ========================================
    */

    class LessonMethods
    {
        // Phương thức Main - điểm khởi đầu của chương trình
        static void Main()
        {
            // Ví dụ: Kiểm tra số hoàn hảo
            Console.Write("Nhập số bộ test: ");
            int t = int.Parse(Console.ReadLine());  // Nhập số bộ test
            for (int i = 1; i <= t; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                int n = int.Parse(Console.ReadLine());
                if (IsPerfectNumber(n))
                {
                    Console.WriteLine($"Test {i}: YES");
                }
                else
                {
                    Console.WriteLine($"Test {i}: NO");
                }
            }

            // Ví dụ: Liệt kê các số chia hết cho k trong đoạn a đến b
            int a = 1, b = 30, k = 6;
            ListedDivisibleByK(a, b, k);
            
            // Ví dụ: Kiểm tra số nguyên tố
            int numToCheck = 21;
            Console.WriteLine($"{numToCheck} là số nguyên tố? {IsPrimeNumber(numToCheck)}");
        }

        /// <summary>
        /// Phương thức kiểm tra xem một số có phải là số hoàn hảo hay không.
        /// Số hoàn hảo là số có tổng các ước số (không bao gồm chính nó) bằng chính nó.
        /// </summary>
        /// <param name="number">Số cần kiểm tra</param>
        /// <returns>Trả về true nếu là số hoàn hảo, false nếu không</returns>
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            // Tính tổng các ước số của number (không bao gồm chính nó)
            for (int k = 1; k < number; k++)
            {
                if (number % k == 0)
                {
                    sum += k;
                }
            }
            // Kiểm tra xem tổng các ước có bằng chính số đó không
            return sum == number;
        }

        /// <summary>
        /// Phương thức liệt kê tất cả các số trong khoảng [a, b] chia hết cho k.
        /// </summary>
        /// <param name="a">Số bắt đầu của đoạn</param>
        /// <param name="b">Số kết thúc của đoạn</param>
        /// <param name="k">Số dùng để chia</param>
        static void ListedDivisibleByK(int a, int b, int k)
        {
            Console.WriteLine($"Các số chia hết cho {k} trong đoạn [{a}, {b}]:");
            for (int i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();  // Xuống dòng sau khi liệt kê xong
        }

        /// <summary>
        /// Phương thức kiểm tra xem một số nguyên có phải là số nguyên tố không.
        /// Số nguyên tố là số chỉ chia hết cho 1 và chính nó.
        /// </summary>
        /// <param name="n">Số nguyên cần kiểm tra</param>
        /// <returns>Trả về true nếu n là số nguyên tố, ngược lại trả về false</returns>
        static bool IsPrimeNumber(int n)
        {
            if (n < 2)  // Nếu nhỏ hơn 2, không phải số nguyên tố
            {
                return false;
            }

            int bound = (int)Math.Sqrt(n);  // Lấy căn bậc hai của n để giảm số phép chia cần kiểm tra
            for (int i = 2; i <= bound; i++)
            {
                if (n % i == 0)
                {
                    return false;  // Nếu có ước khác 1 và chính nó, không phải số nguyên tố
                }
            }
            return true;  // Ngược lại, n là số nguyên tố
        }
    }
}
