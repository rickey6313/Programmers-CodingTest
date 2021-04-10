using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[] { };
        int count = (commands.Length / 3) == 0 ? 1 : (commands.Length / 3);
        answer = new int[count];

        for (int i = 0; i < count; i++)
        {
            int first = commands[i,0];
            int last = commands[i, 1];
            int middle = commands[i, 2];

            int tempCount = (last - first) + 1;
            
            
            int[] copyArr = new int[tempCount];
            if (tempCount >= array.Length) tempCount = array.Length;
            Array.Copy(array, first-1, copyArr, 0, tempCount);

            // int[] copyArr = new int[tempCount];
            // if (tempCount >= array.Length) tempCount = array.Length;
            // for(int n = 0; n < tempCount; n++)
            // {
            //     copyArr[n] = array[n+(first-1)];
            // }
            
            int j = 0, k = 0, temp = 0;
                
            for(j = 0; j < copyArr.Length; j++)
            {
                for (k = j+1; k < copyArr.Length; k++)
                {
                    if(copyArr[j] > copyArr[k])
                    {
                        temp = copyArr[j];
                        copyArr[j] = copyArr[k];
                        copyArr[k] = temp;
                    }
                }
            }
            
            // Array.Sort(copyArr);

            // Array.Copy 보다 Array.Sort가 시간이 더 듦....

            if (copyArr.Length < middle-1)
            {                    
                answer[i] = copyArr[0];
            }
            else
            {
                answer[i] = copyArr[middle-1];
            }
        }
        
        return answer;
    }
}