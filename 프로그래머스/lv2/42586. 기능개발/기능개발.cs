using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        Queue<int> temp = new Queue<int>();
        
        bool job = true;
        int index = 0;
        int max = progresses.Length;
        while(job)
        {
            for(int i = index; i < max; i++)
            {
                progresses[i] += speeds[i];
            }           
            int c = 0;
            for(int i = index; i < max; i++)
            {
                if(progresses[i] >= 100)
                {
                    c++;
                }
                else
                {
                    break;
                }
            }      
            
            index += c;
            if(c > 0)
                temp.Enqueue(c);
            
            if(index == max)
                job = false;
        }
        
        int[] answer = temp.ToArray();
        return answer;
    }
}