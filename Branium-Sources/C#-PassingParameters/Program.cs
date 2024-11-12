using System;

namespace CSharpCourse
{
    /*
    ========================================
    📘 Truyền Tham Chiếu vs Truyền Giá Trị trong C#
    ========================================

    🎯 Khái Niệm
    - Khi gọi phương thức, ta có thể truyền các đối số vào tham số của phương thức bằng 2 cách: **truyền tham chiếu** và **truyền giá trị**.

    🔹 Truyền Giá Trị (Value Passing)
    - Mặc định, các đối số kiểu value type như các kiểu số, `char`, `bool`, `struct` khi truyền vào phương thức là **truyền giá trị**.
    - Khi truyền giá trị, phương thức tạo một bản sao của giá trị, biến gốc không bị ảnh hưởng khi giá trị bản sao thay đổi.

    🔹 Truyền Tham Chiếu (Reference Passing)
    - Truyền tham chiếu là truyền địa chỉ của biến gốc vào tham số của phương thức.
    - Phương thức có thể thay đổi giá trị gốc, không cần tạo bản sao.
    - **C#** cho phép truyền tham chiếu với cả kiểu value type và reference type.

    ========================================
    */

    class PassingParameters
    {
        static void Main()
        {
            Console.WriteLine("Ví dụ: Truyền tham chiếu với từ khóa ref");

            int a = 20;
            int b = 50;
            Console.WriteLine($"Before change. a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After change. a = {a}, b = {b}");

            Console.WriteLine("\nVí dụ: Truyền tham chiếu với từ khóa out");

            GetStudentData(out string fullName, out int age, out float gpa);
            Console.WriteLine($"Full name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"GPA: {gpa}");

            Console.WriteLine("\nVí dụ: Truyền tham chiếu với từ khóa in");

            string msg = "Hello World";
            PrintMessage(in msg);  // Truyền tham chiếu với in (không cho phép thay đổi giá trị gốc)
        }

        /// <summary>
        /// Ví dụ về truyền tham chiếu với từ khóa ref để hoán đổi hai số
        /// </summary>
        /// <param name="first">Số nguyên thứ nhất</param>
        /// <param name="second">Số nguyên thứ hai</param>
        static void Swap(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }

        /// <summary>
        /// Ví dụ về truyền tham chiếu với từ khóa out
        /// </summary>
        /// <param name="fullName">Tên sinh viên</param>
        /// <param name="age">Tuổi sinh viên</param>
        /// <param name="gpa">Điểm trung bình sinh viên</param>
        static void GetStudentData(out string fullName, out int age, out float gpa)
        {
            // Các biến sử dụng với keyword out không cần khởi tạo trước
            Console.Write("Full name: ");
            fullName = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("GPA: ");
            gpa = float.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Ví dụ về truyền tham chiếu với từ khóa in
        /// </summary>
        /// <param name="message">Thông điệp</param>
        static void PrintMessage(in string message)
        {
            Console.WriteLine(message);
            // message không thể bị thay đổi do sử dụng từ khóa in
            // Nếu dòng dưới không bị comment sẽ gây lỗi:
            // message = "New Message"; 
        }
    }

    /*
    ========================================
    📚 Giải Thích Các Từ Khóa Truyền Tham Chiếu
    ========================================

    1. **Keyword ref**:
       - Cho phép phương thức thay đổi giá trị của đối số.
       - Sử dụng `ref` trong định nghĩa và lời gọi phương thức.

    2. **Keyword in**:
       - Truyền tham chiếu ở chế độ chỉ đọc, phương thức không thể thay đổi giá trị.
       - Tăng hiệu năng khi dữ liệu truyền vào có kích thước lớn.

    3. **Keyword out**:
       - Cho phép phương thức thay đổi giá trị của đối số và yêu cầu gán giá trị mới trong phương thức.
       - Sử dụng `out` trong cả định nghĩa và lời gọi phương thức.

    ========================================
    */
}
