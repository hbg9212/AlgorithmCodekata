using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        List<int> list = new List<int>();
        
        for(int i = 1; i < 3000; i++)
        {
            int c = 0;
            for(int j = 1; j <= i; j++)
            {
                if(i%j == 0)
                {
                    c++;
                }
            }
            
            if(c==2)
            {
                list.Add(i);
            }
        }
        
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    int temp = nums[i] + nums[j] + nums[k];
                    if(list.Contains(temp))
                    {
                        answer++;
                    }
                }
            }
        }

        return answer;
    }
}