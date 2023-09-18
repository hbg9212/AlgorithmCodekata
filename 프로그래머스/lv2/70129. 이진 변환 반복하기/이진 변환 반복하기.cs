using System;

public class Solution {
    public int[] solution(string s) {
        int r = 0;
        int d = 0;
        
        int l = s.Length;
        
        while(l > 1)
        {
            r++;
            l = 0;
            char[] array = s.ToCharArray();
            
            foreach(char c in array)
            {
                if(c == '1')
                {
                    l++;
                }
                else
                {
                    d++;
                }
            }
            s = Convert.ToString(l,2);
        }
        
        int[] answer = {r,d};
        return answer;
    }
}