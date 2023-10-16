using System;

public class Solution {
    
    public int solution(string word) {        
        int answer = 0;
        int length = word.Length;
        int numberOfWords = 5;
        int max = 0;
        for(int i = 1; i <= numberOfWords; i++) {
            max += (int)Math.Pow(numberOfWords, i);
        }

        for (int i = 1; i <= length; i++) {
            if (word[i-1] == 'A') {
                answer += 1;
            } else if (word[i-1] == 'E') {
                answer += ((max / (int)Math.Pow(numberOfWords, i)) * 1) + 1;
            } else if (word[i-1] == 'I') {
                answer += ((max / (int)Math.Pow(numberOfWords, i)) * 2) + 1;
            } else if (word[i-1] == 'O') {
                answer += ((max / (int)Math.Pow(numberOfWords, i)) * 3) + 1;
            } else {
                answer += ((max / (int)Math.Pow(numberOfWords, i)) * 4) + 1;
            }
        }
        
       return answer;
        
    }
}