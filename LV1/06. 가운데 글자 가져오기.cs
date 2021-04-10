// Substring을 까먹고 있던 바보 한 마리 추가요

public class Solution {
    public string solution(string s) {
        string answer = "";
        int index = 0;
        int length = 0;

        if (s.Length % 2 == 0)
        {
            index = (s.Length / 2) - 1;
            length = 2;
        }
        else
        {
            index = (s.Length / 2);
            length = 1;
        }

        for(int i = 0; i < length; i++)
        {
            answer = answer + s[index+i].ToString();                
        }

        return answer;
    }
}

// 좋은 모범 답안
public class Solution {
    public string solution(string s) {
        int n = (s.Length+ 1)%2;
        int l = s.Length/2 - n;
        return s.Substring(l, n + 1);
    }
}