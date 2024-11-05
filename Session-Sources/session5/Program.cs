internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // gọi hàm
        int ketQua = tinhTong(10, 11);

        Console.Write($"Tổng 2 số là: {ketQua}");
        Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
        Console.WriteLine("Mời bạn nhập số: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int count = 2; count <= number; count++){
            bool checkPrime = isPrime(count);

            if(checkPrime == true) {
                Console.Write($"{count} ");
            }
        }

        Console.WriteLine("Mời bạn nhập một số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        bool kiemTra = checkSoDoiXung(number3);
        if(kiemTra == true) {
            Console.Write($"Số {number3} là số đối xứng");
        } else {
            Console.Write($"Số {number3} không là số đối xứng");
        }
    }
    //khai báo hàm lấy ra số nghịch đảo
    private static bool checkSoDoiXung(int number){
        int originalNumber = number;
        int reverseNumber = 0;
        // tách hàm
        while(number > 0){
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        if (reverseNumber == originalNumber){
            return true;
        } else {
            return false;
        }
    }

    #region Khai báo hàm kiểm tra số nguyên tố
    // khai báo hàm kiểm tra số nguyên tố
    private static bool isPrime(int number){
        if (number < 2){
            return false;
        }
        for (int count = 2; count <= Math.Sqrt(number); count++){
            if (number % count == 0){
                return false;
            }
        }
        return true;
    }
    #endregion

    // khai báo hàm
    private static int tinhTong(int number1, int number2){
        return number1 + number2;
    }
}