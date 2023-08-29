using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int n = commands[i,0];
            int m = commands[i,1];
            int l = commands[i,2];
            
            List<int> temp = new List<int>();
            for (int j = 0; j < m; j++)
            {
                if(j+1 >= n)
                {
                    temp.Add(array[j]);
                }
            }
            temp = temp.OrderBy(k=>k).ToList();
            answer[i] = temp[l-1];
        }
        return answer;
    }
}