using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int min = 7;
        int max = 7;
        
        for (int i = 0; i < win_nums.Length; i++)
        {
            for (int j = 0; j < win_nums.Length; j++)
            {
                if(lottos[i] == win_nums[j])
                {
                    min--;
                    max--;
                }
            }
            if(lottos[i] == 0)
            {
                max--;
            }
        }
        
        if(min == 7) min--;
        if(max == 7) max--;
        
        int[] answer = new int[] {max, min};
        return answer;
    }
}