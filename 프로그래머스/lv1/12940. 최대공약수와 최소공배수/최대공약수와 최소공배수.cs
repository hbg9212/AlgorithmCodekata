public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        if(n > m)
        {
            int temp = m;
            m = n;
            n = temp;
        }
        
        for(int i = 1; i <= m/2; i++)
        {            
            if(n % i == 0 && m % i == 0)
            {
                answer[0] = i;
            }
        }

        answer[1] = (n * m) / answer[0] ;
        
        return answer;
    }
}