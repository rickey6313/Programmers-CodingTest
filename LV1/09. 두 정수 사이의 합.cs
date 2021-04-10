using System;

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;

        int max = Math.Max(a, b);
        int min = Math.Min(a, b);
        
        for(int i = min; i <= max; i++)
        {
            answer += i;
        }
        return answer;
    }
}

//모범 답안

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;

        while (a != b)
        {
            answer += a;
            a = (a > b) ? a - 1 : a + 1;
        }

        return answer + b;
    }
}