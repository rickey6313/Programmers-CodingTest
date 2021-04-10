public class Solution {
    public int solution(long num) {
        int count = 0;
        if (num == 1)
            return 0;
        while(count <= 500)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num = (num*3)+1;
            }
            count++;
            if (num == 1)
            {
                break;
            }
        }
        count = count <= 500 ? count : -1;
        // Console.WriteLine(count <= 500 ? count : -1);
        return count;
    }
}

좋은 답안

public class Solution {
    public int solution(int num) {
        long lNum = num;
        for (int i = 0; i < 500; i++)
        {
            if (lNum == 1) return i;
            lNum = lNum % 2 == 0 ? lNum / 2 : lNum * 3 + 1;                        
        }
        return -1;        
    }
}
