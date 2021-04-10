using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] arr = n.ToString().ToCharArray();            
        Array.Sort(arr, (a,b) => (a > b) ? -1 : 1);

        answer = long.Parse(new string(arr));
        Console.WriteLine(answer);
        return answer;
    }
}

// 또는

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] a = n.ToString().ToCharArray();
        System.Array.Sort(a);
        System.Array.Reverse(a);
        answer = System.Convert.ToInt64(new string(a));
        return answer;
    }
}