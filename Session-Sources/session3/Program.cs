// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

#region Bài tập số 2
// input
// nhập giá tiền trà sữa
// nhập % giảm giá
// Console.WriteLine("Mời bạn nhập giá tiền trà sữa: ");
// string? giaTien = Console.ReadLine();
// Console.WriteLine("Mời bạn nhập voucher giảm giá: ");
// string? giamGia = Console.ReadLine();

// output
// int tienGiam = 0;
// int tienPhaiTra = 0;

// process
// int formatGiaTien = Convert.ToInt32(giaTien);
// int formatGiamGia = Convert.ToInt32(giamGia);
// tienGiam = formatGiaTien * formatGiamGia / 100;
// tienPhaiTra = formatGiaTien - tienGiam;

// Console.WriteLine($"Số tiền giảm sau khi áp voucher: {tienGiam}");
// Console.WriteLine($"Số tiền phải trả sau khi áp voucher: {tienPhaiTra}");

#endregion

#region if-ele statement
// nhập số nguyên từ bàn phím. In ra số đó là số lẻ hay số chẵn
// input
// Boolean flag = true;
// while(flag) {
//     Console.WriteLine("mời bạn nhập sô nguyên: ");
//     string? number = Console.ReadLine();
//     try {
//         int test = Convert.ToInt32(number);
//         flag = false;
//     } catch {
//         flag = true;
//     }
// }
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// if(formatNumber % 2 == 0) {
//     Console.WriteLine($"Số {number} là số chẵn");
// } else {
//     Console.WriteLine($"Số {number} là số lẻ");
// }

// output

// process

// truthy:
// int day = 5;
// if (day != 0) {
//     // >, <, >=, <=, !=
//     Console.WriteLine("Truthy");
// }

// nhập điểm trung bình của học sinh. Xuất ra học lực của học sinh đó
// >=9: Xuất sắc
// 8 <= điểm < 9: giỏi
// 6.5 <= điểm < 8: khá
// 5 <= điểm <6.5: trung bình
// 3.5 <= điểm < 5: yếu
// quá kém
// string? diemTrungBinh = Console.ReadLine();
// double formatDiem = Convert.ToDouble(diemTrungBinh);
// if(formatDiem >= 9) {
//     Console.WriteLine("Xuất sắc");
// } else if (8 <= formatDiem && formatDiem < 9) {
//     // 8 <= diem <9 (trong ngôn ngữ thực tế)
//     // 8 <= diem && diem <9 (trong lập trình)
//     // kết hợp 2 hoặc nhiều điều kiện
//     // && => và
//     // || => hoặc
//     Console.WriteLine("Giỏi");
// } else if (6.5 <= formatDiem && formatDiem < 8) {
//     Console.WriteLine("Khá");
// } else if (5 <= formatDiem && formatDiem < 6.5) {
//     Console.WriteLine("Trung Bình");
// } else if (3.5 <= formatDiem && formatDiem < 5) {
//     Console.WriteLine("Yếu");
// } else {
//     Console.WriteLine("quá kém");
// }

// nhập số có 3 chữ số và tính tổng 3 chữ số đó
Console.WriteLine("Mời bạn nhập số có 3 chữ số: ");
string? number = Console.ReadLine();
int formatNumber = Convert.ToInt32(number);
if(formatNumber >= 100 && formatNumber < 1000) {
    // 987
    // 9: hunderd, 8: tens, 7: units
    int units = formatNumber % 10; // => 7
    int tens = (formatNumber % 100) / 10; // => 8
    int hundres = formatNumber / 100;

    int sum = units + tens + hundres;
    Console.WriteLine($"Tổng các chữ số có 3 chữ số là: {sum}");
} else {
    Console.WriteLine("Đây không phải là số có 3 chữ số");
}

// 2 -> thứ hai
// 3 -> thứ ba
// 4-> thứ tư

// khi mà các điều kiện nó độc lập với nhau, ko có liên quan với nhau
// if(){}
// if() {}
// if()

// Khi mà các điệu kiện nó có liên quan với nhau
// if(){}
// else if (){}
// else {}

// nhập ngày (dd/mm/yyyy). In ra thứ mấy trong tuần
// VD: 23/10/2024 => thứ tư
// Lưu ý: không dùng thư viện

// switch...case
// c1: dùng switch...case
// nhập số có trong khoảng từ 1 đến 10. Đọc số
string? number2 = Console.ReadLine();
int formatNumber2 = Convert.ToInt32(number2);
switch (formatNumber2)
{
    case 1:
        Console.WriteLine("Số 1");
        break;
    case 2:
        Console.WriteLine("Số 2");
        break;
    case 3:
        Console.WriteLine("Số 3");
        break;
    case 4:
        Console.WriteLine("Số 4");
        break;
    case 5:
        Console.WriteLine("Số 5");
        break;
    case 6:
        Console.WriteLine("Số 6");
        break;
    default:
        Console.WriteLine("Số 10");
        break;
}

// c2: switch expression

#endregion