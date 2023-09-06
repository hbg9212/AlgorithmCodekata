using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;        
        char[] c = s.ToCharArray();

        char temp = c[0];
        int count = 1;
        int unCount = 0;
        
        for(int i = 1; i < c.Length; i++)
        {
            if(i == c.Length -1)
            {
                answer++;
            }
            else
            {
                if(temp == c[i])
                {
                    count++;
                }
                else
                {
                    unCount++;
                }

                if(count == unCount)
                {
                    answer++;
                    temp = c[i+1];
                    count = 0;
                    unCount = 0;
                }
            }
        }
        
        if(answer == 0) answer = 1;
        
        return answer;
    }
}