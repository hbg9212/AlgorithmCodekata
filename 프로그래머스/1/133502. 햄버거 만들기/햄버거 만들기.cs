using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        
        Stack<int> temp = new Stack<int>();
        
        foreach(int i in ingredient)
        {
            temp.Push(i);
            if(temp.Count > 3)
            {
                int a = temp.Pop();
                if(a == 1)
                {
                    int b = temp.Pop();
                    if(b == 3)
                    {
                        int c = temp.Pop();
                        if(c == 2)
                        {
                            int d = temp.Pop();
                            if(d == 1)
                            {
                                answer++;
                            }
                            else
                            {
                                temp.Push(d);
                                temp.Push(c);
                                temp.Push(b);
                                temp.Push(a);
                            }
                        }
                        else
                        {
                            temp.Push(c);
                            temp.Push(b);
                            temp.Push(a);
                        }
                    }
                    else
                    {
                        temp.Push(b);
                        temp.Push(a);
                    }
                }
                else
                {
                    temp.Push(a);
                }
            }
        }
        
        return answer;
    }
}