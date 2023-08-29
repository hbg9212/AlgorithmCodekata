using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strings, int n) {
        List<string> list = strings.ToList();
        list = list.OrderBy(i=>i).ToList();
        list = list.OrderBy(i=>i.Substring(n,1)).ToList();
        string[] answer = list.ToArray();
        return answer;
    }
}