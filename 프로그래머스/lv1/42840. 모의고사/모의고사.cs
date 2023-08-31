using System;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        
        int[] temp1Arr = {1,2,3,4,5};
        int[] temp2Arr = {2,1,2,3,2,4,2,5};
        int[] temp3Arr = {3,3,1,1,2,2,4,4,5,5};

        int temp1 = 0;
        int temp2 = 0;
        int temp3 = 0;
        
        for (int i = 0; i < answers.Length; i ++)
        {
            if ( i == 0 )
            {
                if (answers[i] == temp1Arr[i]) temp1++;
                if (answers[i] == temp2Arr[i]) temp2++;
                if (answers[i] == temp3Arr[i]) temp3++;
            }
            else
            {
                if (answers[i] == temp1Arr[i%5]) temp1++;
                if (answers[i] == temp2Arr[i%8]) temp2++;
                if (answers[i] == temp3Arr[i%10]) temp3++;
            }
        }
        
        if(temp1 >= temp2 && temp1 >= temp3)
        {
            if (temp1 != temp2 && temp1 != temp3)
            {
                answer = new int[] {1};
            }
            else if (temp1 == temp2 && temp1 != temp3)
            {
                answer = new int[] {1,2};
            }
            else if (temp1 != temp2 && temp1 == temp3)
            {
                answer = new int[] {1,3};
            }
            else if(temp1 == temp2 && temp1 == temp3)
            {
                answer = new int[] {1,2,3};
            }
        }
        else if (temp2 >= temp3)
        {
            if(temp2 != temp3)
            {
                answer = new int[] {2};
            }
            else
            {
                answer = new int[] {2,3};
            }
        }
        else
        {
            answer = new int[] {3};
        }

        return answer;
    }
}