using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string temp = "";
        string reverse = "";
        
        while ( n > 0)
        {
            temp = n % 3 + temp;
            n = n / 3;
        }
        
        int multiple = 1;
        
        for (int i = 0; i < temp.Length; i++)
        {
            int a = int.Parse(temp.Substring(i,1));
            if(i != 0)
            {
                for(int j = 1; j < multiple; j++)
                {
                    a = a*3;
                }
            }

            answer += a;
            multiple++;
        }
        
        return answer;
    }
}