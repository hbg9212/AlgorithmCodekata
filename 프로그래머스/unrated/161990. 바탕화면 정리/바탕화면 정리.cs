using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = {51,51,0,0};
        
        for(int i = 0; i < wallpaper.Length; i++)
        {
            char[] temp = wallpaper[i].ToCharArray();
            
            for(int j = 0; j < temp.Length; j++)
            {
                if(temp[j] == '#')
                {
                    if(answer[0] > i)
                    {
                        answer[0] = i;
                    }
                    
                    if(answer[1] > j)
                    {
                        answer[1] = j;
                    }
                    
                    if(answer[2] < i+1)
                    {
                        answer[2] = i+1;
                    }
                    
                    if(answer[3] < j+1)
                    {
                        answer[3] = j+1;
                    }
                }
            }
        }  
        return answer;
    }
}