using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;

        Dictionary<string, int> dic = new Dictionary<string, int>();
        
        for(int i = 0; i < want.Length; i++)
        {
            dic.Add(want[i], number[i]);
        }
        
        for(int i = 0; i <= discount.Length - 10; i++)
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();
            for(int j = 0; j < 10; j++)
            {
                string discnt = discount[i + j];
                int cnt = temp.GetValueOrDefault(discnt);
                cnt++;
                temp[discnt] = cnt;
            }
            
            bool trigger = true;
        
            foreach(KeyValuePair<string, int> element in dic)
            {
                int wantCnt = element.Value;
                int disCnt = temp.GetValueOrDefault(element.Key);
                
                if(wantCnt > disCnt)
                {
                    trigger = false;
                    break;
                }
            }
            
            if(trigger == true)
            {
                answer++;
            }
        }

        return answer;
    }
}