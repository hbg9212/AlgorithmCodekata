using System;

public class Solution {
        
    public int solution(int[] numbers, int target) {    
        return DFS(numbers, target, 0, 0);
    }
    
    public int DFS(int[] numbers, int target, int i, int c)
    {
        if (i == numbers.Length)
        {
            if (c == target)
                return 1;
            else
                return 0;
        }

        int a = DFS(numbers, target, i + 1, c + numbers[i]);
        int b = DFS(numbers, target, i + 1, c - numbers[i]);

        return a + b;
    }
}