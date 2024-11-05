// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Học phép toán cơ bản
// học +, -, *, / (chia lấy phần nguyên), % (chia  lấy phần dư)
// khai báo biến
// int add = 5 + 10;
// Console.WriteLine($"Kêt quả cộng hai số 5 và 10 là: {add}");

// int minus = 1231231 - 34546;
// Console.WriteLine($"Kết quả trừ hai số 1231231 và 34546 là: {minus}");

// double devide = 5 / 2;
// Console.WriteLine($"Kết quả chia lấy phần nguyên hai số 5 và 2 là: {devide}");

#endregion

#region numberic toán tử
// phím tắt command nhiều dòng code cùng một lúc
// win: Ctrl + ?
// mac: Cmd + ?

// int cong = 0; // định nghĩa biến cong có giá trị mặc định 0
// cong += 10;
// Console.WriteLine($"Numberic toán tử cộng: {cong}");

// int nhan = 1;
// nhan *= 100;
// Console.WriteLine($"Numberic toán tử nhân: {nhan}");
#endregion

#region ép kiểu dữ liệu C1: Dùng Convert
// Convert
// nhập dữ liệu từ bàn phím => ReadLine (string)
Console.WriteLine("Mời bạn nhập số: ");
string number = Console.ReadLine();

int convertNumber = Convert.ToInt32(number);
int sum = convertNumber + 1;

Console.WriteLine($"value number: {sum}");
#endregion

#region Tính chỉ số BMI
// INPUT
// Chiều cao và cân nặng được nhập từ bàn phím
Console.WriteLine("Mời bạn nhập chiều cao (m)");
string chieuCao = Console.ReadLine();
// convert string -> double
double formatChieuCao = Convert.ToDouble(chieuCao);

Console.WriteLine("Mời bạn nhập cân nặng (kg)");
string canNang = Console.ReadLine();
double formatCanNang = Convert.ToDouble(canNang);

// OUTPUT
// in ra chỉ số BMI
// khởi tạo biến bmi để lưu giá trị BMI
double bmi = 0.0;

// PROCESS
// BMI = (cân nặng) / (chiều cao)*(chiều cao)
bmi = formatCanNang / (formatChieuCao*formatChieuCao);
Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");

#endregion

#region Tính chu vi và diện tích hình tròn
// input
// B1: Nhập bán kính từ bàn phím
Console.WriteLine("mời bạn nhập bán kính hình tròn: ");
string banKinh = Console.ReadLine();
// B2: Convert kiểu dữ liệu string -> double cho bán kính
double formatBanKinh = Convert.ToDouble(banKinh);

// output
double chuVi = 0.0;
double dienTich = 0.0;

// process
// chu vi = 2*pi*banKinh
// diện tích = pi*banKinh*banKinh
double PI = Math.PI; // dùng hằng số PI có sẵn của thư viện Math trong C#
chuVi = 2 * PI * formatBanKinh;
dienTich = PI * formatBanKinh * formatBanKinh;
Console.WriteLine($"chu vi hình tròn là: {chuVi}");
Console.WriteLine($"Diện tích hình tròn là: {dienTich}");
#endregion
