public class Solution {
    public bool solution(int x) {
        int temp = x;
        int sum = 0;
        
        while (temp%10 > 0 || temp >= 10)
        {
            sum += temp%10;
            temp = temp/10;
        }
        
        bool answer = x%sum == 0 ? true : false;
        
        return answer;
    }
}