using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {

        
        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();
        List<int> tempReserveList = reserve.ToList();

        reserveList = reserveList.Except(lostList).ToList();
        lostList = lostList.Except(tempReserveList).ToList();
        lostList = lostList.OrderBy(i => i).ToList();
        int answer = n - lostList.Count;
        int a = -1;
        int b = 0;
                
        if(reserveList.Count > 0)
        {
            for(int i = 0; i < lostList.Count; i++)
            {
                b = lostList[i];
                if(a < b - 1 && reserveList.Contains(b - 1))
                {
                    a = b - 1;
                    answer++;
                }
                else if(reserveList.Contains(b + 1))
                {
                    a = b + 1;
                    answer++;
                }
            }
        }

        return answer;
    }
}