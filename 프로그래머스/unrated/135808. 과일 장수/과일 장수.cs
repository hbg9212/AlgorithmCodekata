using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        List<int> list = score.ToList();
        list = list.OrderByDescending(i => i).ToList();
        
        for(int i = 0; i < list.Count; i++)
        {
            if(i + m - 1 < list.Count)
            {
                answer += list[ i + m -1] * m;
                i = i + m - 1;
            }
        }
        
        return answer;
    }
}