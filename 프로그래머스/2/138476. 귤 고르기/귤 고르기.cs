using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        List<int> list = new List<int>();
        list.AddRange(tangerine);
        
        list = list.OrderBy(item => item).ToList();
        
        List<int> count = new List<int>();
        int min = list[0];
        int c = 0;
        
        for(int i = 0; i < list.Count(); i++)
        {
            if(min == list[i])
            {
                c++;
            }
            else
            {
                min = list[i];
                count.Add(c);
                c = 1;
            }
            if(i == list.Count() -1)
            {
                count.Add(c);
            }
            
        }
        
        count = count.OrderByDescending(item => item).ToList();
        int t = 0;
        
        for(int i = 0; i < count.Count(); i++)
        {
            answer++;
            if( t + count[i] >= k)
            {
                break;
            }
            else
            {
                t = t + count[i];
            }
        }
        
        return answer;
    }
}