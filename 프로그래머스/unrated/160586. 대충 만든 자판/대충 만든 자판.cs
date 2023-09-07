using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        List<char[]> keyList = new List<char[]>();      
        
        for(int i = 0; i < keymap.Length; i++)
        {
            char[] temp = keymap[i].ToCharArray();
            keyList.Add(temp);
        }
        
        int index = 0;
        int tempIndex = 0;
        for(int i = 0; i < targets.Length; i++)
        {
            index = 0;
            char[] temp = targets[i].ToCharArray();
            foreach(char c in temp)
            {
                tempIndex = 0;
                for(int k = 0; k < 100; k++)
                {
                    for(int j = 0; j < keyList.Count; j++)
                    {
                        if(keyList[j].Length > k)
                        {
                            if(keyList[j][k] == c)
                            {
                                index = index + k + 1;
                                tempIndex = k + 1;
                                break;
                            }
                        }
                    }
                    if(tempIndex > 0)
                    {
                        break;
                    }
                }
                if(tempIndex == 0)
                {
                    index = 0;
                    break;
                }
            }
            index = index == 0 ? -1 : index;
            answer[i] = index;
        }
        
        return answer;
    }
}