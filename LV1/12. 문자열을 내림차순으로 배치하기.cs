using System;

public class Solution {
    public string solution(string s) {
        string answer = "";

        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        Array.Reverse(chars);
                answer = new string(chars);
        return answer;
        
    }
}
