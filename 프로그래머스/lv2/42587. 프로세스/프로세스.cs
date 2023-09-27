using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        
        Queue<int> temp = new Queue<int>();
        Queue<int> l = new Queue<int>();
        
        int max = 0;
        
        for(int i = 0; i < priorities.Length; i++)
        {
            if(max < priorities[i])
                max = priorities[i];
            
            temp.Enqueue(priorities[i]);
            if(i == location)
            {
                l.Enqueue(1);
            }
            else
            {
                l.Enqueue(0);
            }
        }
        
        while(temp.Count > 0)
        {
            if(temp.Contains(max))
            {
                int a = temp.Dequeue();
                int b = l.Dequeue();
                if(a == max)
                {
                    answer++;
                    if(b == 1)
                    {
                        break;
                    }
                }
                else if(a < max)
                {
                    temp.Enqueue(a);
                    l.Enqueue(b);
                }
            }
            else
            {
                max--;
            }
        }
        return answer;
    }
}