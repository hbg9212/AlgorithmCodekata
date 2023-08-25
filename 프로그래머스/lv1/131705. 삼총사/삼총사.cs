using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        
        for( int n = 0; n < number.Length; n++)
        {
            for ( int m = n + 1; m < number.Length; m++)
            {
                for ( int l = m + 1; l < number.Length; l++)
                {
                    if (number[n] + number[m] + number[l] == 0)
                        answer++;
                }
            }
        }
        
        return answer;
    }
}