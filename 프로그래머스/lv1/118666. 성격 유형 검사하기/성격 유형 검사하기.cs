using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        int[] RT = new int[2];
        int[] CF = new int[2];
        int[] JM = new int[2];
        int[] AN = new int[2];
        
        for(int i = 0; i < survey.Length; i++)
        {
            string s = survey[i].Substring(0,1);
            int a = choices[i] - 4;
            if(a < 0)
            {
                a = a * -1;
                if(s == "R")
                {
                    RT[0] = RT[0] + a; 
                }
                else if(s == "T")
                {
                    RT[1] = RT[1] + a; 
                }
                else if(s == "C")
                {
                    CF[0] = CF[0] + a; 
                }
                else if(s == "F")
                {
                    CF[1] = CF[1] + a; 
                }
                else if(s == "J")
                {
                    JM[0] = JM[0] + a; 
                }
                else if(s == "M")
                {
                    JM[1] = JM[1] + a; 
                }
                else if(s == "A")
                {
                    AN[0] = AN[0] + a; 
                }
                else if(s == "N")
                {
                    AN[1] = AN[1] + a; 
                }                
            }
            else if (a > 0)
            {
                if(s == "R")
                {
                    RT[1] = RT[1] + a; 
                }
                else if(s == "T")
                {
                    RT[0] = RT[0] + a; 
                }
                else if(s == "C")
                {
                    CF[1] = CF[1] + a; 
                }
                else if(s == "F")
                {
                    CF[0] = CF[0] + a; 
                }
                else if(s == "J")
                {
                    JM[1] = JM[1] + a; 
                }
                else if(s == "M")
                {
                    JM[0] = JM[0] + a; 
                }
                else if(s == "A")
                {
                    AN[1] = AN[1] + a; 
                }
                else if(s == "N")
                {
                    AN[0] = AN[0] + a; 
                } 
            }
        }
        
        if(RT[0] >= RT[1])
        {
            answer = "R";
        }
        else
        {
            answer = "T";
        }
         
        if(CF[0] >= CF[1])
        {
            answer = answer + "C";
        }
        else
        {
            answer = answer + "F";
        }
         
        if(JM[0] >= JM[1])
        {
            answer = answer + "J";
        }
        else
        {
            answer = answer + "M";
        }
         
        if(AN[0] >= AN[1])
        {
            answer = answer + "A";
        }
        else
        {
            answer = answer + "N";
        }

        return answer;
    }
}