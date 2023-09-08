using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        List<int> list = new List<int>();
        for(int i = 97; i <= 122; i++)
        {
            list.Add(i);
        }
        
        char[] skipArry = skip.ToCharArray();
        foreach(char c in skipArry)
        {
            list.Remove((int)c);
        }

        char[] temp = s.ToCharArray();
        foreach(char c in temp )
        {
            int i = list.IndexOf((int)c);
            
            if(index < list.Count)
            {            
                i = i + index < list.Count ? i + index : i + index - list.Count; 
            }
            else
            {
                i = i + index%list.Count < list.Count ? i +  index%list.Count : i + index%list.Count - list.Count; 
            }

            answer = answer + (char)list[i];
        }
        return answer;
    }
}