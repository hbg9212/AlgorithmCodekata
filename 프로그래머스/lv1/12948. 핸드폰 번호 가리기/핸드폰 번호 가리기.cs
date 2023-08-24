public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        for(int i = 0; i < phone_number.Length; i++)
        {
            if( i < phone_number.Length - 4)
            {
                answer = answer + "*";
            }
            else
            {
                answer = answer + phone_number.Substring(i,1);
            }
        }
        
        return answer;
    }
}