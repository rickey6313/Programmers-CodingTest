// 배열이 많을 경우 버블정렬을 극악의 속도를 자랑한다..
using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] { };
        List<int> answerList = new List<int>();
        // for(int i = 0; i < arr.Length; i++)
        // {
        //     for (int j = 0; j < arr.Length; j++)
        //     {
        //         if(arr[j] > arr[i])
        //         {
        //             int temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }
        // }

        Array.Sort(arr);
        
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
                answerList.Add(arr[i]);
        }

        if (answerList.Count == 0)
            answer = new int[] { -1 };
        else
            answer = answerList.ToArray();
        return answer;
    }
}

// 좋은 모범 답안
int[] answer = new int[] { };
List<int> answerList = new List<int>();

if (divisor != 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % divisor == 0)
            answerList.Add(arr[i]);
    }

    if (answerList.Count == 0)
        answerList.Add(-1);
}
else                
    answerList.AddRange(arr);

answerList.Sort();

answer = answerList.ToArray();

return answer;