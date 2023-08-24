using System;
public class Solution {
    public long solution(double n) {
        long answer = -1;
        long i = (long)Math.Sqrt(n);
        if(i*i == n)
        {
            i++;
            answer = i * i;
        }
        return answer;
    }
}