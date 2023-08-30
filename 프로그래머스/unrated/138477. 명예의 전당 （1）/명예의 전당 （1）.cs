using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> temp = new List<int>();
        
        for ( int i = 0; i < score.Length; i++)
        {
            int min = 0;
            if ( i < k ) 
            {
                temp.Add(score[i]);
                temp = temp.OrderByDescending(n=>n).Take(i+1).ToList();
                min = temp[i];
            }
            else
            {
                temp.Add(score[i]);
                temp = temp.OrderByDescending(n=>n).Take(k).ToList();
                min = temp[k-1];
            }
            answer[i] = min;
        }
        
        return answer;
    }
}