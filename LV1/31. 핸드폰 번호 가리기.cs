public class Solution {
    public string solution(string num) {
        string answer = "";
        char[] temp = num.ToCharArray();
        for(int i = 0; i < num.Length-4; i++)
        {
            temp[i] = '*';
        }
        answer = new string(temp);
        return answer;
    }
}