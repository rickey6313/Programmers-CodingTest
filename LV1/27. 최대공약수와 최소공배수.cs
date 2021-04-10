유클리드 호제법
https://ko.wikipedia.org/wiki/유클리드_호제법

public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];

        int a = n;
        int b = m;

        int gcd = 1;
        int lcm = 1;
        while (m != 0)
        {
            int r = n % m;
            n = m;
            m = r;
        }

        gcd = n;

        lcm = gcd * (a / gcd) * (b / gcd);

        answer[0] = gcd;
        answer[1] = lcm;

        return answer;
    }
}