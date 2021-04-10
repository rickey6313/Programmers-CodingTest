using System;
public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[] { };
        char[] arr = n.ToString().ToCharArray();            
        Array.Reverse(arr);
        answer = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            answer[i] = int.Parse(arr[i].ToString());
        }
        return answer;
    }
}