using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        double temp1 = 0;
        long temp2 = 0;
        switch (n & 0x0f)
        {
            case 0:
            case 1:
            case 4:
            case 9:
                temp1 = Math.Sqrt(n);
                temp2 =  (long)Math.Sqrt(n);
                if (temp1 == temp2)
                {
                    answer = (temp2 + 1) * (temp2 + 1);
                }
                else
                    answer = -1;
                break;
            default:
                answer = -1;
                break;
        }
        Console.WriteLine(answer);
        return answer;
    }
}

// 좋은 코드
using System;
public class Solution {
    public long solution(long n) {
        long x = (long)Math.Sqrt(n);
            return (x*x == n) ? (x+1)*(x+1) : -1;
    }
}

using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;

        var sqrt = Math.Sqrt(n);

        if (sqrt % 1.0 != 0)
            return -1;

        answer = (long)sqrt;

        answer += 1;
        answer *= answer;

        return answer;
    }
}