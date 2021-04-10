public class Solution {
    public string solution(int num) {
        if (num == 0)
            return "Even";

        return num % 2 == 0 ? "Even" : "Odd";
    }
}