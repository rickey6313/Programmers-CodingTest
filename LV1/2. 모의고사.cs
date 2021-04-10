using System;

public class Solution {
    public int[] solution(int[] answers) {
        
        int[] person1 = new int[] { 1, 2, 3, 4, 5 };
        int[] person2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] person3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int[] answerArr = new int[3];
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == person1[i % 5]) { answerArr[0]++; }
            if (answers[i] == person2[i % 8]) { answerArr[1]++; }
            if (answers[i] == person3[i % 10]) { answerArr[2]++; }
        }

        int[] arr = new int[3];
        for(int i = 0; i < answerArr.Length; i++)
        {
            arr[i] = answerArr[i];
        }

        Array.Sort(arr);

        int max = arr[2];
        int count = 1;
        for(int i = arr.Length-1; i >= 1; i--)
        {
            if(arr[2].CompareTo(arr[i-1]) == 0)
            {
                count++;
            }
        }

        int[] answer = new int[count];
        int j = 0;
        for(int i=0; i < answerArr.Length; i++)
        {
            if(answerArr[i] == max)
            {
                answer[j] = i + 1;
                j++;
            }
        }
        
        return answer;
    }
}