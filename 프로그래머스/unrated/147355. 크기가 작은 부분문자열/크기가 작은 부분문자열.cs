using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long intP = long.Parse(p);
        int size = p.Length;
        
        if (t.Length == size)
        {
            if(long.Parse(t) <= intP)
                answer++;
        }
        else
        {
            for ( int i = 0; i <= (t.Length - size); i++)
            {
                if(long.Parse(t.Substring(i,size)) <= intP)
                    answer++;
            }

        }
        return answer;
    }
}