using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "0";
        
        for(int i = food.Length-1; i >0 ;i--)
        {
            for(int j = 0; j < food[i]/2; j++)
            {
                answer = i + answer + i;
            }
        }
        
        if(answer.Length < 3) answer = "";
        
        return answer;
    }
}