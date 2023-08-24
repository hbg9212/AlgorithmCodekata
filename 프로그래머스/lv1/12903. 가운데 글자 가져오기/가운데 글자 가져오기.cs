public class Solution {
    public string solution(string s) {
        int index = s.Length/2;
        
        bool isEven = s.Length % 2 == 0 ? true : false;
        
        string answer = "";
        
        if(isEven)
        {
            answer = s.Substring(--index,2);    
        }
        else
        {
            answer = s.Substring(index,1);
        }
        
        return answer;
    }
}