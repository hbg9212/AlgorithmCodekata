using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int x = arr1.GetLength(0);
        int y = arr2.GetLength(1);
        int z = arr2.GetLength(0);
        
        int[,] answer = new int[x,y];
        
        for(int i = 0; i < x; i++)
        {
            for(int n = 0; n < y; n++)
            {
                int a = 0;
                for(int j = 0; j < z; j++)
                {
                    a = a + (arr1[i,j] * arr2[j,n]);  
                }
                answer[i,n] = a;
            }
        }
        
        return answer;
    }
}