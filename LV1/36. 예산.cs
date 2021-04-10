using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int count = 0;

        Array.Sort(d);

        for(int i = 0; i < d.Length; i++)
        {
            if (d[i] > budget) continue;
            int sum = d[i];
            int tempCount = 1;

            for (int j = 0; j < d.Length; j++)
            {
                if (i == j)
                    continue;

                sum += d[j];
                if (sum <= budget)
                    tempCount++;
                else
                    sum -= d[j];

            }
            count = count > tempCount ? count : tempCount;
        }

        Console.WriteLine(count);
        return count;
    }
}