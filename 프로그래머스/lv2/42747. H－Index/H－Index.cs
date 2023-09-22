using System;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        
        int[] c = new int[10001];
        
        for(int i = 0; i < citations.Length; i++)
        {
            if(citations[i] > 0)
            {
                for(int j = 1; j <= citations[i]; j++)
                {
                    c[j] +=1;
                }
            }
        }
        
        for(int i = 0; i < c.Length; i++)
        {
            if(c[i] != 0 && i <= c[i])
            {
                answer = i;
            }
        }
        
        return answer;
    }
}