using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string,int> name = new Dictionary<string,int>();
        Dictionary<int,string> temp = new Dictionary<int,string>();
        
        for(int i = 0; i < players.Length; i ++)
        {
            name.Add(players[i],i);
            temp.Add(i,players[i]);
        }
        foreach(string s in callings)
        {
            int a = name[s];
            string str = temp[a-1];
            
            name[s] -= 1;
            name[str] +=1;
            
            temp[a-1] = s;
            temp[a] = str;
            
        }

        string[] answer = new string[players.Length];
        
        for(int i = 0; i < players.Length; i++)
        {
            answer[i] = temp[i];
        }
        
        return answer;
    }
}