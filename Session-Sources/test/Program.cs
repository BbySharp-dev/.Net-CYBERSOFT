Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
Console.WriteLine("Mời bạn nhập số: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int count = 2; count <= number; count++){
    bool isPrime = true;
    for(int j = 2; j <= Math.Sqrt(count); j++){
        if(count % j == 0){
            isPrime = false;
            break;
        }
    }

    if(isPrime == true) {
        Console.Write($"{count} ");
    }
}
Console.WriteLine();

Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// ____*
// ___* *
// __*   *
// _*     *
// *********

Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");
Console.WriteLine("Mời bạn nhập một số: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int originalNumber = number3;
int reverseNumber = 0;
while(number3 > 0){
    int lastDigit = number3 % 10;
    reverseNumber = reverseNumber * 10 + lastDigit;
    number3 = number3 / 10;
}
if (reverseNumber == originalNumber){
    Console.WriteLine($"Số {originalNumber} là số đối xứng");
} else {
    Console.WriteLine($"Số {originalNumber} không là số đối xứng");
}
// B1: lấy số 1: => dư = number % 10
// reverseNumber = reverseNumber * 10 + dư
// number = number / 10; => 12
// B2: lấy 2: => dư = number %10 => 2
// reverseNumber = reverseNumber*10 + dư => 12
// number = number / 10; => 1
// B3: lấy 1 = > dư = number % 10 => 1
// reverseNumber = reverseNumber * 10 + dư => 121
// number = number / 10; => 0