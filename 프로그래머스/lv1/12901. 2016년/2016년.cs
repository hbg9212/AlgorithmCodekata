public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        int[] tempArr = {0,31,29,31,30,31,30,31,31,30,31,30,31};
        
        for (int i = 1; i < a; i++)
        {
            b += tempArr[i];
        }
        
        b = b % 7;
        
        switch (b)
        {
            case 0:
                answer = "THU";
                break;    
            case 1:
                answer = "FRI";
                break; 
            case 2:
                answer = "SAT";
                break; 
            case 3:
                answer = "SUN";
                break; 
            case 4:
                answer = "MON";
                break; 
            case 5:
                answer = "TUE";
                break; 
            case 6:
                answer = "WED";
                break; 
        }
        
        return answer;
    }
}