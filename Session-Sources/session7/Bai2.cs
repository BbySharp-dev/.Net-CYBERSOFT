class Bai2 {
    public static int findMaxNumber(List<int> numbers) {
        int max = numbers.ElementAt(0); // int max = numbers[0]
        foreach (int number in numbers) {
            if(number > max) {
                max = number;
            }
        }
        return max;
    }
}