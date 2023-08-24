public class Solution {
    public string solution(int n) {
        bool isEven = n % 2 == 0 ? true : false;
        int index = n/2;
        string answer = "";
        
        if (isEven)
        {
            for(int i = 0; i < index; i++)
            {
                answer = answer + "수박";
            }
        }
        else
        {
            for(int i = 0; i < index; i++)
            {
                answer = answer + "수박";
            }
            answer = answer + "수";
        }
        
        return answer;
    }
}