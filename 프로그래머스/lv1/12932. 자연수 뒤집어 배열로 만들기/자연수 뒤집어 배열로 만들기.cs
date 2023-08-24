using System;
public class Solution
{
    public int[] solution(long n)
    {
        int c = (int)Math.Log10(n);
        int[] answer = new int[++c];
        for (int i = 0; i < c; i++)
        {
            answer[i] = (int)(n % 10);
            n = n / 10;
        }

        return answer;
    }
}