using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int x = 0;
        int y = 0;
        
        List<char[]> xPoint = new List<char[]>();
        List<char[]> yPoint = new List<char[]>();
        
        for(int i = 0; i < park.Length; i++)
        {
            xPoint.Add(park[i].ToCharArray());
        }

        for(int i = 0; i < xPoint[0].Length; i++)
        {
            char[] t = new char[park.Length];
            for(int j = 0; j < park.Length; j++)
            {
                t[j] = xPoint[j][i];
                if(xPoint[j][i] == 'S')
                {
                    x = i;
                    y = j;
                }
            }
            yPoint.Add(t);
        }

        foreach(string s in routes)
        {
            string d = s.Substring(0,1);
            int n = int.Parse(s.Substring(2,1));
            if(d == "N" || d == "S")
            {
                char[] t = yPoint[x];
                int temp = y;
                for(int i = 0; i < n; i++)
                {
                    int m = d == "N" ? temp - 1 : temp + 1;
                    if(m >= 0 && m < t.Length)
                    {
                        if(t[m] == 'X')
                        {
                            temp = -1;
                            break;
                        }
                        else
                        {
                            temp = m;
                        }
                    }
                    else
                    {
                        temp = -1;
                        break;
                    }
                } 
                if(temp >= 0)
                {
                    y = temp;
                }
            }
            else if(d == "W" || d == "E")
            {
                char[] t = xPoint[y];
                int temp = x;
                for(int i = 0; i < n; i++)
                {
                    int m = d == "W" ? temp - 1 : temp + 1;
                    if(m >= 0 && m < t.Length)
                    {
                        if(t[m] == 'X')
                        {
                            temp = -1;
                            break;
                        }
                        else
                        {
                            temp = m;
                        }
                    }
                    else
                    {
                        temp = -1;
                        break;
                    }
                } 
                if(temp >= 0)
                {
                    x = temp;
                }
            }

        }
        
        int[] answer = {y,x};
        return answer;
    }
}