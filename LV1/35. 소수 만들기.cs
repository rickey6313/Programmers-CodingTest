using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        
        List<int> temp = new List<int>();
            
        for (int i= 0; i < numbers.Length; i++)
        {
            for (int j = numbers.Length-1; i < j; j--)
            {
                int sum = numbers[i] + numbers[j];
                bool find = false;

                for(int k = 0; k < temp.Count; k++)
                {
                    if (temp[k] == sum)
                        find = true;
                }

                if(!find)
                    temp.Add(sum);

            }
        }
        temp.Sort();

        answer = new int[temp.Count];
        for(int i = 0; i < temp.Count; i++)
        {
            answer[i] = temp[i];
        }
        
        return answer;
    }
}