internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region kiểm tra số nguyên tố
        Console.WriteLine("Mời bạn nhập số: ");
        // string? number = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatNumber);
        // if (isPrime == true){
        //     Console.WriteLine($"Số {number} là số nguyên tố");
        // } else {
        //     Console.WriteLine($"Số {number} không là số nguyên tố");
        // }
        #endregion

        #region In ra tam giác vuông có chiều cao n nhập từ bàn phím
        // Console.WriteLine("Mời bạn nhập chiều cao tam giác: ");
        // string? height = Console.ReadLine();
        // int formatHeight = Convert.ToInt32(height);
        // Method.printSquareTriangle(formatHeight);
        // // for (int i = 1; i <= formatHeight; i++) {
        // //     Method.printRowTriangle(i);
        // // }
        #endregion

        #region Collection trong C#
        // data structure
        // List
        List<int> numbers = new List<int>();

        // define giá trị ban đầu
        List<string> names = new List<string> {"Phuong", "Duc", "Linh", "Hung", "Tri"};
        //                            index       0        1       2       3      4
        //                         reverseIndex   ^5       ^4      ^3      ^2     ^1
        Console.WriteLine($"phần tử thứ 2 là: {names[2]}");
        Console.WriteLine($"Phần tử nghịch đảo là: {names[^3]}");
        // Console.WriteLine(names);
        // Lưu ý: WriteLine chỉ in được giá trị cho những kiểu dữ liệu nguyên thủy: int, float, double, string,...
        // Còn kiểu dữ liệu Collection thì chỉ in ra địa chỉ vùng nhớ của biến đó
        Console.Write(String.Join(", ", names));

        // bài tập làm quen: nhập n từ bàn phím. Sau đó nhập n phần tử và xuất ra n phần tử
        Console.WriteLine("Mời bạn nhập số lượng phần tử: ");
        string? number = Console.ReadLine();
        int formatNumber = Convert.ToInt32(number);
        // tạo biến chứa danh sách phần tử
        List<int> listNumbers = new List<int>();
        for(int i = 0; i < formatNumber; i++){
            // C1: dùng insert
            Console.WriteLine($"Nhập phần tử thứ {i+1}");
            string? item = Console.ReadLine();
            int formatItem = Convert.ToInt32(item);
            listNumbers.Insert(i, formatItem);
        }
        // in list phần tử ra ngoài màn hình
        // sẽ có 2 cách duyệt phần tử: for hoặc foreach
        // C1: for
        Console.WriteLine("Danh sách phần tử sau khi nhập là: ");
        for(int i = 0; i < listNumbers.Count; i++){ // listNumbers.Count => 5
            Console.WriteLine(listNumbers[i]);
        }

        // C2: dùng foreach
        Console.WriteLine("Danh sách phần tử dùng foreach: ");
        foreach(int item in listNumbers) {
            Console.WriteLine(item);
        }
        #endregion
    }
}