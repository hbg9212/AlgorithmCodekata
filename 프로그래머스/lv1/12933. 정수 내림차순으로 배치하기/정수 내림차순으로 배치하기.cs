using System;
public class Solution {
    public long solution(long n) {
        long c = (long)Math.Log10(n);
        int[] arr = new int[++c];
        for(int i =0; i<c; i++)
        {            
            arr[i] = (int)(n%10);
            n = n/10;
        }
        for(int x = 0; x<c; x++)
        {
            for(int i = 1; i<c; i++)
            {
                if(arr[i-1] < arr[x])
                {
                    int t = arr[x];
                    arr[x] = arr[i-1];
                    arr[i-1] = t;
                }
            }
        }
        long answer = 0;
        for(int i =0; i<c; i++)
        {
            answer = answer *10 + arr[i];
        }

        
        return answer;
    }
}