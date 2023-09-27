using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 0;
        
        Dictionary<string, int> temp = new Dictionary<string, int>();
        
        for(int i = 0; i < clothes.GetLength(0); i++)
        {
            string str = clothes[i,1];
            int cnt = temp.GetValueOrDefault(str);
            cnt++;
            temp[str] = cnt;
        }
        
        foreach(KeyValuePair<string, int> element in temp)
        {
            answer = answer + element.Value + (answer * element.Value);
        }

        return answer;
    }
}