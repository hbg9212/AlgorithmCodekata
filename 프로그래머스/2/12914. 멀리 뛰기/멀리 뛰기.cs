public class Solution {
    public long solution(int n) {
        long answer = 0;
        int[] temp = new int[n+2];
        
        for (int i = 0; i < n+2; i++)
        {
            if(i > 1)
            {
                temp[i] = (temp[i-1] + temp[i-2])%1234567;
            }
            else if (i == 1)
            {
                temp[i] = 1;
            }
            answer = temp[i];
        }
        
        return answer;
    }
}