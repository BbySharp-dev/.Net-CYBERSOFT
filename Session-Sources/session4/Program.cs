// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// while
// for
// do...while
// quan trọng nhất là xác định điều kiện dừng

#region while statement
// in ra các số từ 1 đến n với n là số được nhập từ bàn phím
// B1: khởi tạo giá trị lặp
// B2: xác định điều lặp (tính tới trường hợp dừng)
// B3: thay đổi điều kiện lặp
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// while(count <= formatNumber) {
//     Console.WriteLine(count);
//     count++; // count = count + 1;
// }


// nhập số n từ bàn phím. In ra tổng các số từ 1 -> n
// S = 1 + 2 + 3 + .... + n;
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int sum = 0;
// while (count <= number) {
//     sum += count; // sum = sum + count
//     count++; // count = count + 1 hoặc count +=1
// }
// Console.WriteLine($"Tổng các số từ 1 đến n là: {sum}");

// tính giai thừa của 1 số
// int number = Convert.ToInt32(Console.ReadLine());
// // 5! => 120
// int count = 1;
// int factorial = 1;
// while(count <= number){
//     factorial *= count;
//     count++;
// }
// Console.WriteLine($"Giai thừa của số {number} là: {factorial}");

// in bảng cửu chương
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= 10)
// {
//     Console.WriteLine($"{count} x {number} = {count*number}");
//     count++;
// }

// kiểm tra số n có phải là số nguyên tố hay không
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// giả sử a và b là ước của n
// ít nhất 1 trong 2 số a và b phải nhỏ hơn căn bậc 2 của n
// vì nếu a và b lớn hơn căn bậc 2 của n thì khi a*b sẽ lớn hơn n
// VD: n=9 => căn bậc 2 của 9 = 3
// while(count < number){ // count <= Math.Sqrt(number) (count < căn bậc 2 của n)
//     if(number % count == 0){
//         Console.WriteLine($"Số {number} không phải là số nguyên tố");
//         break;
//     }
//     count++; // quan trọng
// }
// if (count == number) {
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }

#endregion

#region For statement
// in bảng cửu chương
// int number = Convert.ToInt32(Console.ReadLine());
// for(int count = 1; count <= 10; count++) {
//     Console.WriteLine($"{count} x {number} = {count*number}");
// }

// kiểm tra số nguyên tố
// int number = Convert.ToInt32(Console.ReadLine());
// int count;
// for(count = 2; count < number; count++){
//     if(number % count == 0){
//         Console.WriteLine($"Số {number} không phải là số nguyên tố");
//         break;
//     }
// }
// if (count == number){
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }

// for lồng nhau => ma trận (nhiều mảng kết hợp với nhau)
// 1 2 3 4 5
// 2 3 4 5 6
// 5 6 7 4 3
 
// *******
// *******
// *******

Console.WriteLine("Mời bạn nhập chiều dài: ");
int chieuDai = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mời bạn nhập chiều rộng: ");
int chieuRong = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < chieuRong; i++){
    for(int j = 0; j < chieuDai; j++){
        Console.Write("*");
    }
    Console.Write("\n"); //Console.WriteLine()
}
//       j => 2*i+1
// i=0:   ___* => height - i - 1
// i=1:   __*** => height = 2, in ra 2 space, và 3*
// i=2:   _***** => height = 3, in ra 1 space, và 5 *
// i=3:   *******
Console.WriteLine("Mời bạn nhập chiều cao tam giác: ");
int height = Convert.ToInt32(Console.ReadLine());
for(int i = 0;i < height;i++){
    // in khoảng trắng (space) trước dấu *
    for(int j = 0; j < height - i - 1; j++) {
        Console.Write(" ");
    }
    // in dấu *
    for(int k = 0; k < (2*i+1); k++){
        Console.Write("*");
    }
    Console.WriteLine();
}

// ***************
// *             *
// *             *
// *             *
// ***************

#endregion


