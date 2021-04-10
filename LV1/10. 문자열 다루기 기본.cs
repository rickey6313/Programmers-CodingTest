public class Solution {
    public bool solution(string s) {        
        int check = 0;
        bool isLength = false;
        bool isNum = int.TryParse(s, out check);
        if (s.Length == 4 || s.Length == 6)
            isLength = true;
        else
            isLength = false;

        return isLength && isNum;
    }
}

public class Solution {
    public bool solution(string s) {
            bool answer = false;
            if (s.Length == 4 || s.Length == 6)            
                answer = int.TryParse(s, out int i);            
            return answer;
    }
}