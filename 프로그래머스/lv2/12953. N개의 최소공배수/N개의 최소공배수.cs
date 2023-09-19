public class Solution {
    public long solution(int[] arr) {
        long answer = 0;
        int[] temp = arr;
        
        for(int i = 1; i < temp.Length; i++)
        {
            int min = gcd(temp[i-1], arr[i]);
            int max = (temp[i-1] * arr[i]) / min;
            temp[i] = max;
            answer = max;
        }
        
        return answer;
    }
    
    public int gcd(int n, int m)
    {
        if(m==0) return n;
        else return gcd(m, n%m);
    }
}