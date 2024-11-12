using System;

namespace CSharp_BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\n1. Kiểm tra số âm, dương hoặc bằng 0");
                Console.WriteLine("\n2. Tính thuế thu nhập cá nhân");
                Console.WriteLine("\n3. Xác định mùa trong năm");
                Console.WriteLine("\n4. Kiểm tra tuổi và phân loại");
                Console.WriteLine("\n5. Kiểm tra số nguyên tố");
                Console.WriteLine("\n6. Tính tiền điện");
                Console.WriteLine("\n7. Xác định hạng vé xem phim");
                Console.WriteLine("\n8. Tính tiền taxi");
                Console.WriteLine("\n9. Kiểm tra ký tự nguyên âm hay phụ âm");
                Console.WriteLine("\n10. Xác định loại vé máy bay");
                Console.WriteLine("\n11. Bài học buổi 3");
                Console.WriteLine("\n12. Thoát");
                Console.WriteLine("Chọn bài tập để chạy.");

                Console.Write("\nNhập lựa chọn của bạn: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Bai1_KiemTraSoAmDuong.Bai1_KiemTraSoAmDuong.Run();
                        break;
                    case "2":
                        Bai2_TinhThue.Bai2_TinhThue.Run();
                        break;
                    case "3":
                        Bai3_XacDinhMuaTrongNam.Bai3_XacDinhMuaTrongNam.Run();
                        break;
                    case "4":
                        Bai4_KiemTraTuoi.Bai4_KiemTraTuoi.Run();
                        break;
                    case "5":
                        Bai5_KiemTraSoNguyenTo.Bai5_KiemTraSoNguyenTo.Run();
                        break;
                    case "6":
                        Bai6_TinhTienDien.Bai6_TinhTienDien.Run();
                        break;
                    case "7":
                        Bai7_XacDinhHangVe.Bai7_XacDinhHangVe.Run();
                        break;
                    case "8":
                        Bai8_TinhTienTaxi.Bai8_TinhTienTaxi.Run();
                        break;
                    case "9":
                        Bai9_KiemTraNguyenAm.Bai9_KiemTraNguyenAm.Run();
                        break;
                    case "10":
                        Bai10_XacDinhLoaiMayBay.Bai10_XacDinhLoaiMayBay.Run();
                        break;
                    case "11":
                        BaiHocBuoi3.BaiHocBuoi3.Run();
                        break;
                    case "12":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }
            }
        }
    }
}
