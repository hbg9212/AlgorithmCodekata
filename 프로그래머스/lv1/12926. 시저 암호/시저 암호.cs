public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] chars = s.ToCharArray();
        for ( int i = 0; i < s.Length; i ++)
        {
            char c = chars[i];
            int temp = (int)c;
            if(temp != 32)
            {
                temp += n;
                if((int)c > 96)
                {
                    if(temp > 122)
                    {
                        temp -= 26;
                    }
                }
                else
                {
                   if(temp > 90)
                    {
                        temp -= 26;
                    }
                }
                c = (char)temp;
            }
            answer = answer + c;
        }
        return answer;
    }
}