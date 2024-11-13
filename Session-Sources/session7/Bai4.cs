class Bai4 {
    public static List<int> unquieNumbers(List<int> numbers) {
        List<int> results = new List<int>();
        results.Add(numbers.ElementAt(0));
        for(int i = 1; i < numbers.Count; i++) {
            // c1
            // if(results.Contains(i) == false) {
            //     results.Add(i);
            // }
            // c2: so sánh phần tử đằng trước
            if (numbers[i] != numbers[i-1]) {
                results.Add(numbers[i]);
            }
        }
        return results;
    }
}