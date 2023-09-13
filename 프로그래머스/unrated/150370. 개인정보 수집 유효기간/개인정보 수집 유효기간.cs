using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> temp = new List<int>();

        string[] strArray = today.Split(".");
        int[] todays = new int[3];
        
        for(int i = 0; i < strArray.Length; i++)
        {
            todays[i] = int.Parse(strArray[i]);
        }
        
        List<string[]> t = new List<string[]>();
        
        for(int i =0; i < terms.Length; i++)
        {
            t.Add(terms[i].Split(" "));
        }
        
        for(int i = 0; i < privacies.Length; i++)
        {
            string term = privacies[i].Substring(11);
            string[] privacie = privacies[i].Substring(0,10).Split(".");
            int[] p = new int[3];
            for(int a = 0; a < privacie.Length; a++)
            {
                p[a] = int.Parse(privacie[a]);
            }

            int index = t.FindIndex(item => item[0] == term );
           
            int b =  int.Parse(t[index][1]);

            p[2] = p[2] - 1;           
            p[1] = p[1] + b;
            
            Console.WriteLine(p[1]);
            
            if(p[1] > 12)
            {
                p[0] = p[0] + (p[1] - 1)/12;
                p[1] = p[1] % 12 == 0 ? 12 : p[1] % 12;
            }

            if(p[2] == 0)
            {
                p[2] = 28;
                p[1] = p[1] - 1;
            }

            if(p[1] == 0)
            {
                p[1] = 12;
                p[0] = p[0] - 1;
            }
            
            if(todays[0] == p[0])
            {
                if(todays[1] == p[1])
                {
                    if(todays[2] > p[2])
                    {
                        temp.Add(i+1); 
                    }
                }
                else if(todays[1] > p[1])
                {
                    temp.Add(i+1); 
                }
            }
            else if(todays[0] > p[0])
            {
               temp.Add(i+1); 
            }
        }
        int[] answer = temp.ToArray();
        return answer;
    }
}