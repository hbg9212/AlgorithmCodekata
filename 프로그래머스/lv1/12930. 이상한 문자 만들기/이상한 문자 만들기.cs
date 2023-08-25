public class Solution {
    public string solution(string s) {
        string[] tempArr = s.Split(" ");
        string answer = "";
        
        for(int i = 0; i < tempArr.Length; i++ )
        {
            string temp = "";
            for(int j = 0; j < tempArr[i].Length; j++ )
            {
                if ( j == 0)
                {
                    temp = tempArr[i].Substring(0,1).ToUpper();
                }
                else if ( j % 2 == 0)
                {
                    temp = temp + tempArr[i].Substring(j,1).ToUpper();
                }
                else if ( j % 2 == 1)
                {
                     temp = temp + tempArr[i].Substring(j,1).ToLower();
                }
            }
            tempArr[i] = temp;
        }
        
        for (int i = 0; i < tempArr.Length; i++)
        {
            if ( i == 0)
            {
                answer = tempArr[i];
            }
            else
            {
                answer = answer + " " + tempArr[i];
            }
        }
            
        return answer;
    }
}