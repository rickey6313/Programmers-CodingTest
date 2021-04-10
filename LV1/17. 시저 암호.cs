using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] arr = s.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if ((int)arr[i] == 32)
            {
                arr[i] = (char)32;
            }
            else
            {
                // 소문자인데 +했더니 90을(Z) 넘기는지
                if(char.IsLower(arr[i]) && (int)arr[i]+n > 122)
                {
                    arr[i] = (char)(((int)arr[i] + n) - 26);
                }
                // 대문자인데 +했더니 122를(z) 넘기는가
                else if (char.IsUpper(arr[i]) && (int)arr[i] + n > 90)
                {
                    arr[i] = (char)(((int)arr[i] + n) - 26);
                }
                else
                {
                    arr[i] = (char)((int)arr[i] + n);
                }
            }
        }            
        answer = new string(arr);
        // Console.WriteLine(answer);
        return answer;
    }
}