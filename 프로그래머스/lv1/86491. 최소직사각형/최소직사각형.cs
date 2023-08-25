using System;

public class Solution {
    public int solution(int[,] sizes) {
        int[] tempArr = {0,0};
        for ( int i = 0; i < sizes.GetLength(0); i++)
        {
            int a = sizes[i,0];
            int b = sizes[i,1];
            
            if (a < b)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            
            if(tempArr[0] < a) tempArr[0] = a;
            if(tempArr[1] < b) tempArr[1] = b;

        }
                
        int answer = tempArr[0] * tempArr[1];
        return answer;
    }
}