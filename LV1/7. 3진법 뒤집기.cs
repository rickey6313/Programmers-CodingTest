using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int div = n;
        int b = 0;
        List<int> temp = new List<int>();
        while(true)
        {
            if (div >= 3)
            {
                b = div % 3;
                temp.Add(b);                    
                div = div / 3;  
            }
            else
            {                    
                temp.Add(div);
                break;
            }

        }
        double index = 0;
        for(int i = temp.Count-1; i >= 0; i--)
        {
            if(i == temp.Count-1)
            {
                answer += temp[i] * 1;
            }
            else
            {
                answer += temp[i] * (int)Math.Pow(3, index);
            }                
            index++;                
        }

        return answer;
    }
}


좋은 코드.. 대가리 진짜 개 좋네 인간들


public class Solution{
    public int solution(int n)
    {
        int answer=0;
        while(n>0){
            answer*=3;
            answer+=n%3;
            n/=3;
        }
        return answer;
    }    
}

45
answer = 0;
while(n>0)
{
    answer *= 3     // answer = 0
    answer += n%3   // answer = 0
    n/=3        // n = 15

    answer *= 3     // answer = 0
    answer += n%3   // answer = 0
    n/=3        // 5

    answer *= 3     // answer = 0
    answer += n%3   // answer = 2
    n/=3        // n = 1

    answer *= 3     // answer = 6
    answer += n%3   // answer = 7
    n/=3        // n = 0

}

125
answer = 0;
while(n>0)
{
    answer *= 3     // answer = 0
    answer += n%3   // answer = 2
    n/=3        // n = 41

    answer *= 3     // answer = 6
    answer += n%3   // answer = 8
    n/=3        // 13

    answer *= 3     // answer = 24
    answer += n%3   // answer = 25
    n/=3        // n = 4

    answer *= 3     // answer = 75  
    answer += n%3   // answer = 76
    n/=3        // n = 1

    answer *= 3     // answer = 228
    answer += n%3   // answer = 229
    n/=3        // n = 0
}
```