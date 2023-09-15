using System;

public class Solution {
    public string solution(string s) {
        string[] temp = s.Split(" ");
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        
        foreach(string str in temp)
        {
            int n = int.Parse(str);
            if( min > n)
            {
                min = n;
            }
            
            if( max < n)
            {
                max = n;
            }
        }

        string answer = min + " " + max;
        return answer;
    }
}