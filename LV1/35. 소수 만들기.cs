using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        List<int> temp = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    answer = nums[i] + nums[j] + nums[k];                        
                    temp.Add(answer);
                    answer = 0;
                }
            }
        }

        answer = 0;

        for (int i = 0; i < temp.Count; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= temp[i]/2; j++)
            {
                if (temp[i] % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
                answer++;
        }

        return answer;
    }
}