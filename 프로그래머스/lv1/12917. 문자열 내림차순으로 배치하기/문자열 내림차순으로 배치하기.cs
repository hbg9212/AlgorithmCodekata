using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int index = s.Length;
        List<string> capital = new List<string>();
        List<string> small = new List<string>();
        
        for(int i = 0; i < index; i++)
        {
            string str = s.Substring(i,1);
            if(char.IsUpper(char.Parse(str)))
            {
                capital.Add(str);
            }
            else
            {
                small.Add(str);
            }
        }
        
        capital = capital.OrderByDescending(i => i).ToList();
        small = small.OrderByDescending(i => i).ToList();
        
        foreach(string str in small)
        {
            answer = answer + str;
        }
        foreach(string str in capital)
        {
            answer = answer + str;
        }
        
        return answer;
    }
}