using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] splitstr = s.Split(' ');
        int lastindex = splitstr.Length;
        for (int i = 0; i < lastindex; i++)
        {
            char[] arr;
            if (i == lastindex - 1)
                arr = new char[splitstr[i].Length];
            else
                arr = new char[splitstr[i].Length+1];

            for(int j = 0; j < splitstr[i].Length; j++)
            {
                arr[j] = splitstr[i][j];
            }
            for (int j = 0; j < arr.Length; j++)
            {                    
                if(j%2 == 0)
                {
                    arr[j] = char.ToUpper(arr[j]);
                }
                else
                {
                    arr[j] = char.ToLower(arr[j]);
                }

                if (i != lastindex - 1 && j == arr.Length - 1)
                {
                    arr[j] = (char)32;
                }

            }
            answer += new string(arr);
        }


        Console.WriteLine(answer);
        return answer;
    }
}

// 좀더 좋은 코드
using System.Text;

public class Solution
{
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();
        bool isUpper = true;

        foreach (var ch in s)
        {
            if (' ' == ch)
            {
                sb.Append(ch);
                isUpper = true;
                continue;
            }

            sb.Append(isUpper ? char.ToUpper(ch) : char.ToLower(ch));
            isUpper = !isUpper;
        }

        return sb.ToString();
    }
}

//또는

public class Solution {
    public string solution(string s) {
        string answer = "";
        int num = 0;

        for(int i = 0; i < s.Length; i++)
        {
            answer += num % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();

            num = s[i] == ' '? 0 : num + 1;

        }


        return answer;
    }
}