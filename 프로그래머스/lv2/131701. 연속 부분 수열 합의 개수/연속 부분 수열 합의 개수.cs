using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
       int s = elements.Length; 
        
        List<int> temp = new List<int>();
        
        for (int i = 1; i <= elements.Length; i++) {
            for (int j = 0; j < elements.Length; j++) {
                int sum = 0;
                for (int k = 0; k < i; k++) {
                    if (j + k > elements.Length - 1) {
                        sum += elements[j + k - elements.Length];
                    } else {
                        sum += elements[j + k];
                    }
                }
                temp.Add(sum);
            }
        }

        temp = temp.Distinct().ToList();
        int answer = temp.Count();
        return answer;
    }
}