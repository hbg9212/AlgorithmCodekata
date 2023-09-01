using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int temp = 0;

        for(int i = 0; i < section.Length; i++)
        {
            
            if(temp < section[i])
            {

                if(m == 1)
                {
                    temp = section[i];
                }
                else
                {
                    temp = section[i] + m-1;
                }
                answer++;
            }

        }

        return answer;
    }
}