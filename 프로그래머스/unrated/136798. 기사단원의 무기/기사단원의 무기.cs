using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i <= number; i++)
        {
            int temp = 1;
            
            for(int j = 1; j <= (i/2); j++)
            {
                if(i % j == 0)
                {
                    temp++;
                    if(temp > limit)
                    {
                        break;
                    }
                }
            }

            if(temp > limit)
            {
                answer += power;
            }
            else
            {
                answer += temp;
            }
            
        }
        
        return answer;
    }
}