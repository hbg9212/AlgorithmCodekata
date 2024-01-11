using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        char[] cArray = s.ToCharArray();
        for(int i = 0; i < s.Length; i++)
        {
            int temp = -1;
            for(int j = i-1; j >= 0; j--)
            {
                if(cArray[j] == cArray[i])
                {
                    temp = i - j;
                    break;
                }
            }
            answer[i] = temp;
        }
        return answer;
    }
}