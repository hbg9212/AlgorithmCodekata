public class Solution {
    public int solution(string s) {
        int answer = 0;
        bool parseSuccess = int.TryParse(s, out var ret);
        if (parseSuccess)
        {
            answer =  ret;
        }
        return answer;
    }
}