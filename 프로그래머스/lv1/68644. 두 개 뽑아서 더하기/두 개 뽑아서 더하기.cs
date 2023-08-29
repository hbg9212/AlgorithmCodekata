using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> answerList = new List<int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)   
            {
                answerList.Add(numbers[i]+numbers[j]);
            }
        }
        answerList = answerList.Distinct().ToList();
        answerList = answerList.OrderBy(i=>i).ToList();
        int[] answer = answerList.ToArray();
        return answer;
    }
}