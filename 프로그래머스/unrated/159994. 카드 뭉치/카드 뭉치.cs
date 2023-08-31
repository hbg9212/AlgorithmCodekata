using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int index1 = 0;
        int index2 = 0;
        
        for(int i = 0; i < goal.Length; i++)
        {
            if(goal[i] == cards1[index1])
            {
                index1++;
                if (index1 >= cards1.Length) index1 = cards1.Length -1;
            }
            else if(goal[i] == cards2[index2])
            {
                index2++;
                if (index2 >= cards2.Length) index2 = cards2.Length -1;
            }
            else
            {
                answer = "No";
                break;
            }

        }
        
        
        return answer;
    }
}