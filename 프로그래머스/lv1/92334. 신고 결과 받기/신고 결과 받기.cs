using System;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int n = id_list.Length;
        
        int[] answer = new int[n];
        
        int[,] temp = new int[n,n];
        int[] s = new int[n];
        
        foreach(string str in report)
        {
            string[] tempArray = str.Split(" "); 
            int x = Array.IndexOf(id_list, tempArray[0]);
            int y = Array.IndexOf(id_list, tempArray[1]);
            
            if(temp[x,y] == 0)
            {
                temp[x,y] = 1;
            }
        }
        
        for(int i = 0; i < n; i ++)
        {
            int a = 0;
            for(int j = 0; j < n; j++)
            {
                if(temp[j,i] == 1)
                {
                    a++;
                }
            }
            
            if(a >= k)
            {
                s[i] = 1;
            }
        }
        
        for(int i = 0; i < n; i++)
        {
            if(s[i] == 1)
            {
                for(int j = 0; j < n; j++)
                {
                    if(temp[j,i] == 1)
                    {
                        answer[j] += 1;
                    }
                }
            }
        }
               
        return answer;
    }
}