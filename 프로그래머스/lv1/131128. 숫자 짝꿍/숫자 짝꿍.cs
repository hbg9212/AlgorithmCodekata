using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        List<char> listX = X.ToCharArray().ToList();
        List<char> listY = Y.ToCharArray().ToList();

        listX = listX.OrderByDescending(i=>i).ToList();
        listY = listY.OrderByDescending(i=>i).ToList();
        
        int indexX = -1;
        int indexY = -1;
        int r = 0;
        
        for(int i = 9; i > -1; i--)
        {
            int tempX = listX.FindLastIndex(c => c == (char)(i + '0'));
            int tempY = listY.FindLastIndex(c => c == (char)(i + '0'));

            if(tempX > -1 && tempY > -1)
            {
                if(tempX - indexX >= tempY - indexY)
                {
                    r = tempY - indexY;
                }
                else
                {
                    r = tempX - indexX;
                }

                string str = new string((char)(i + '0'), r);
                answer = answer + str;
            }
              
            if(tempX > -1)
            {
                indexX = tempX;
            }
            
            if(tempY > -1)
            {
                indexY = tempY;
            }
            
        }
        
        if(answer == "") answer = "-1";
        if(answer.Substring(0,1) == "0") answer = "0";
        
        return answer;
    }
}