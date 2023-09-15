using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] temp = s.ToCharArray();
        
        bool f = true;

        foreach(char c in temp)
        {
            char t = c;
            if(f)
            {
                f = false;
                t = Char.ToUpper(c);
            }
            else
            {
                t = Char.ToLower(c);
            }

            if((int)c == 32)
            {
                f = true;
            }
            
            answer = answer + t;
        }
        
        return answer;
    }
}