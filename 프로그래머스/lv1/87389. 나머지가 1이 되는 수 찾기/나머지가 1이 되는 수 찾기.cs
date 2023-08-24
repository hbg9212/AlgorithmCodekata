using System;

public class Solution {
    public int solution(int n) {
        int answer = n;
        int i = n;
        while ( i > 1)
        {
            if(n%i == 1) answer = i;
            --i;
        }
        return answer;
    }
}