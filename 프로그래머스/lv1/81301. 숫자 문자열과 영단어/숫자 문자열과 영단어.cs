using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        for (int i = 0; i < s.Length; i ++)
        {
            bool parseSuccess = int.TryParse(s.Substring(i,1), out var ret);
            if (parseSuccess)
            {
                answer = (answer*10) + ret;
            }
            else
            {

                int temp = -1;
                string str3 = s.Substring(i,3);

                switch (str3)
                {
                    case "one":
                        temp = 1;
                        i += 2;
                        break;
                    case "two":
                        temp = 2;
                        i += 2;
                        break;
                    case "six":
                        temp = 6;
                        i += 2;
                        break;
                }

                if(temp == -1)
                {
                    string str4 = s.Substring(i,4);

                    switch (str4)
                    {
                        case "zero":
                            temp = 0;
                            i += 3;
                            break;
                        case "four":
                            temp = 4;
                            i += 3;
                            break;
                        case "five":
                            temp = 5;
                            i += 3;
                            break;
                        case "nine":
                            temp = 9;
                            i += 3;
                            break;
                    }
                }
                
                if(temp == -1)
                {
                    string str5 = s.Substring(i,5);

                    switch (str5)
                    {
                        case "three":
                            temp = 3;
                            i += 4;
                            break;
                        case "seven":
                            temp = 7;
                            i += 4;
                            break;
                        case "eight":
                            temp = 8;
                            i += 4;
                            break;
                    }
                }
                
               answer = (answer*10) +temp;

            }
        }
        
        return answer;
    }
}