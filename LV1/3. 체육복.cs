using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        List<int> reserveList = new List<int>();
        List<int> lostList = new List<int>();
        reserveList.AddRange(reserve);
        lostList.AddRange(lost);
        
        for(int i = 0; i < lostList.Count; i++)
        {
            if (reserveList.Contains(lostList[i]))
            {
                int index = reserveList.FindIndex(x => x.CompareTo(lostList[i]) == 0);                    
                reserveList.Remove(lostList[i]);
                lostList.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < lostList.Count; i++)
        {
            if (reserveList.Contains(lostList[i] - 1))
            {
                int index = reserveList.FindIndex(x => x.CompareTo(lostList[i] - 1) == 0);
                reserveList.RemoveAt(index);
                lostList.RemoveAt(i);
                i--;
            }
            else if (reserveList.Contains(lostList[i] - 1) || reserveList.Contains(lostList[i] + 1))
            {
                int index = reserveList.FindIndex(x => x.CompareTo(lostList[i] + 1) == 0);
                reserveList.RemoveAt(index);
                lostList.RemoveAt(i);
                i--;
            }
        }
        
        answer = n - lostList.Count;
        
        return answer;
        
    }
}