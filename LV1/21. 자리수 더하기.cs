public class Solution {
    public int solution(int n) {
        int answer = 0;

        string s = n.ToString();

        foreach(char num in s)
        {                
            answer += int.Parse(num.ToString());
        }
        Console.WriteLine(answer);
        return answer;
    }
}

// 또는
public class Solution{
    public int solution(int n) {
        int answer = 0;
                while(n>0)
                {
                        answer += n%10;
                        n /= 10;
                }
        Console.WriteLine(answer);
        return answer;
    }
}