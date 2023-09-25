using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[(right+1) - left];
        
        int idx = 0;
        
        for (long i = left; i <= right; i++)
        {      
            answer[idx] = (int)((i / n) < (i % n) ? (i % n) + 1 : (i / n) + 1);
            idx++;
        }

        return answer;
    }
}