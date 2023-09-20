using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public bool Check(Queue<char> queue)
    {
        Stack<char> stk = new Stack<char>();
        
        char[] left = new char[3]{'(', '[', '{'};
        char[] right = new char[3]{')', ']', '}'};
        
        foreach(char element in queue)
        {
            if(stk.Count == 0)
            {
                foreach(char r in right)
                {
                    if(element == r)
                    {
                        return false;
                    }
                }
                
                stk.Push(element);
            }
            else
            {
                switch(element)
                {
                    case ')':
                        if(stk.Peek() == '(')
                        {
                            stk.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if(stk.Peek() == '[')
                        {
                            stk.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if(stk.Peek() == '{')
                        {
                            stk.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default :
                        stk.Push(element);
                        break;
                }
            }
        }
        
        if(stk.Count != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    public int solution(string s)
    {
        int answer = 0;
        Queue<char> que = new Queue<char>();
        
        foreach(char element in s)
        {
            que.Enqueue(element);
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            bool isCorrect = Check(que);
            
            if(isCorrect == true)
            {
                answer++;
            }
            
            que.Enqueue(que.Dequeue());
        }
        
        return answer;
    }
}