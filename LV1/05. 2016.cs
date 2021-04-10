// 달력 계산 알고리즘 자체를 몰라서 인터넷에서 달력 알고리즘을 검색했음.

// 요일을 구하려면 먼저

// 구하려는 해당 년월의 1일까지의 모든 일수(allday)를 구한다. (윤년 공식이 같이 포함됨 시벌 개쩜)

// 만약 윤년이면 1월달에 +1일을 한다.

// 모든일수를 7로 나눠서 0부터 6까지 차례로 일~토가 된다..

using System;

public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int[] month = new int[12]{ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int mon = a;
        int day = b;

        int allday = 0;
        int remain;
        int year = 2016;
        allday = ((year - 1) + (year - 1) / 4 - (year - 1) / 100 + (year - 1) / 400);

        int i = 0;
        for (i = 0; i < mon; i++)
        {
            if (i == 1 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
            {
                month[1] += 1;
            }
            allday += month[i];
        }
        allday -= month[i - 1];
        remain = (allday + 1) % 7;
        i = (remain + day - 1) % 7; //요일계산
        answer = i == 0 ? "SUN" : i == 1 ? "MON" : i == 2 ? "TUE" : i == 3 ? "WED" : i == 4 ? "THU" : i == 5 ? "FRI" : i == 6 ? "SAT" : "";
        return answer;
    }
}