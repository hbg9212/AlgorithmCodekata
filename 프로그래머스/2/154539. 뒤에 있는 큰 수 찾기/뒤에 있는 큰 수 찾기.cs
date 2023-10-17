using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> list = new List<int>(); 
        Stack<int> stack = new Stack<int>(); 
        
        stack.Push(numbers[numbers.Length - 1]);
        list.Add(-1);
        
        for (int i = numbers.Length - 2; i >= 0; i--)
        {
            int num = -1;

            while (stack.Count != 0)
            {
                if (stack.Peek() > numbers[i])
                {
                    num = stack.Peek();
                    break;
                }
                else
                {
                    stack.Pop();
                }
            }
            list.Add(num);
            stack.Push(numbers[i]);
        }
        
        int[] answer = list.ToArray();
        Array.Reverse(answer);
        return answer;
    }
}