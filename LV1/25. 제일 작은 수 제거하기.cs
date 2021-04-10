using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> arrList = new List<int>(arr);
            
        if (arr.Length == 1)
            return new int[] { -1 };
        int[] temp = new int[arr.Length];
        arr.CopyTo(temp, 0);
        Array.Sort(temp);
        int findValue = Array.Find(arr, find => find == temp[0]);

        arrList.RemoveAll(find => find == findValue);

        if(arrList.Count == 0)
            return new int[] { -1 };

        return arrList.ToArray();
    }
}