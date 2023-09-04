using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] tempStr = {"aya", "ye", "woo", "ma"};
        
        for(int i = 0; i < babbling.Length; i++)
        {
            string str = babbling[i];
            int strLength = str.Length;
            int tempAnswer = 0;
            if(strLength > 1)
            {
                string s = "";
                for(int j = 0; j < strLength; j++)
                {
                    for(int k = 0; k < tempStr.Length; k++)
                    {
                        if(tempStr[k].Length + j <= strLength)
                        {
                            if(tempStr[k] == str.Substring(j,tempStr[k].Length))
                            {
                                if(s != tempStr[k])
                                {
                                    s = tempStr[k];
                                    j += tempStr[k].Length -1;
                                    tempAnswer += tempStr[k].Length;
                                }
                            }
                        }
                    }
                }
                if(tempAnswer == strLength)
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}