namespace console_app.Exercises
{
    public class Exercise2
    {
        /// <summary>
        /// Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá.
        /// </summary>
        /// <remarks>
        /// Yêu cầu người dùng nhập vào giá trị của đơn hàng và phần trăm giảm giá.
        /// </remarks>
        /// <example>
        /// Ví dụ: Nếu giá trị đơn hàng là 1000 và giảm giá 20%, tổng số tiền phải thanh toán sẽ là 800.
        /// </example>
        /// <param name="giaTriCuaDonHang">Giá trị của đơn hàng.</param>
        /// <param name="phanTramGiamGia">Phần trăm giảm giá.</param>
        /// <returns>Tổng số tiền phải thanh toán sau khi áp dụng giảm giá.</returns>

        public void Run()
        {
            Console.WriteLine("Nhập vào giá trị của đơn hàng:");

            if (!decimal.TryParse(Console.ReadLine(), out decimal giaTriCuaDonHang))
            {
                Console.WriteLine("Vui lòng nhập giá trị của đơn hàng hợp lệ và không để trống.");
                return;
            }

            if (giaTriCuaDonHang <= 0)
            {
                Console.WriteLine("Giá trị đơn hàng phải lớn hơn 0.");
                return;
            }

            Console.WriteLine("Nhập vào phần trăm giảm giá của đơn hàng:");

            if (!decimal.TryParse(Console.ReadLine(), out decimal phanTramGiamGia))
            {
                Console.WriteLine("Vui lòng nhập phần trăm giảm giá hợp lệ và không để trống.");
                return;
            }

            if (phanTramGiamGia < 0 || phanTramGiamGia > 100)
            {
                Console.WriteLine("Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100.");
                return;
            }

            decimal giaGiam = giaTriCuaDonHang * (phanTramGiamGia / 100);
            decimal giaSauKhiGiam = giaTriCuaDonHang - giaGiam;

            Console.WriteLine($"Sau khi giảm {phanTramGiamGia}%, giá sản phẩm còn lại là {giaSauKhiGiam} VNĐ.");
        }
    }
}
