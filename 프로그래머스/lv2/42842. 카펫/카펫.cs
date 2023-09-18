using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int x = 0;
        int y = 0;
        
        int temp = brown + yellow;
        List<int> divisors = new List<int>();

        for (int i = 3; i <= temp/3 +1; i++)
        {
            if (temp % i == 0)
            {
                divisors.Add(i);
            }
        }

        for(int i =0; i< divisors.Count; i++)
        {
            if(divisors[i] <= temp/divisors[i])
            {
                y = divisors[i];
                x = temp/divisors[i];
            }
            if(brown == 2*x + 2*y -4)
            {
                break;
            }
            
        }
        
        int[] answer = {x, y};

        return answer;
    }
}