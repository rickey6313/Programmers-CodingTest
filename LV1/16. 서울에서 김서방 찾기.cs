public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int index = 0;
        for(int i = 0; i < seoul.Length; i++)
        {
            if(seoul[i].CompareTo("Kim") == 0)
            {
                index = i;
                break;
            }
        }
        // Console.WriteLine("김서방은 "+ index +"에 있다");
        answer = string.Format("김서방은 {0}에 있다", index);
        return answer;

    }
}