public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] temp = new int[n+1];
  
        for(int i = 0; i < n+1; i++)
        {
            if( i < 2)
            {
                answer = i;
            }
            else
            {
                answer = temp[i-1] + temp[i-2];
                answer = answer % 1234567;
            }
            temp[i] = answer;
        }
        return answer;
    }
}