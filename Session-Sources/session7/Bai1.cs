class Bai1 {

    public static int tinhTongSoLon50(List<int> numbers) {
        int sum = 0;
        foreach (int number in numbers) {
            if (number >= 50) {
                sum += number; // sum = sum + number
            }
        }
        return sum;
    }
}