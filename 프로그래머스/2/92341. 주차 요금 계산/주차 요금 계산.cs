using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {

        Dictionary<string, string> staTime = new Dictionary<string, string>();
        Dictionary<string, string> endTime = new Dictionary<string, string>();
        Dictionary<string, int> fee = new Dictionary<string, int>();
        
        int baseTime = fees[0];
        int baseFee = fees[1];
        int unitTime = fees[2];
        int unitFee = fees[3];
        
        foreach(string str in records)
        {
            string[] temp = str.Split(" ");
            
            string time = temp[0];
            string carNum = temp[1];
            string chk = temp[2];
    
            if(staTime.ContainsKey(carNum))
            {
                endTime.Add(carNum, time);
            }
            else
            {
                staTime.Add(carNum, time);
            }
            
            if(chk == "OUT")
            {
                int minuteSpent = TimeSpent(staTime[carNum],endTime[carNum]);

                                
                if(!fee.ContainsKey(carNum))
                {
                    fee.Add(carNum, minuteSpent);
                }
                else
                {
                    fee[carNum] = fee[carNum] + minuteSpent;
                }
                
                staTime.Remove(carNum);
                endTime.Remove(carNum);
            }
        }
        
        if(staTime.Count > 0)
        {
            string dayEnd = "23:59";
            
            foreach(KeyValuePair<string, string> temp in staTime)
            {
                int minuteSpent = TimeSpent(temp.Value,dayEnd);

                if(!fee.ContainsKey(temp.Key))
                {
                    fee.Add(temp.Key, minuteSpent);
                }
                else
                {
                    fee[temp.Key] = fee[temp.Key] + minuteSpent;
                }
            }
        }
        fee = fee.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
        int[] answer = new int[fee.Count];
        int i = 0;
        foreach(KeyValuePair<string, int> temp in fee)
        {
            int addTime = temp.Value - baseTime;
            int addFee = 0;
            
            while ( addTime > 0)
            {
                addFee += unitFee;
                addTime -= unitTime;
            }
            
            answer[i] = baseFee + addFee;
            i++;
        }
        
        return answer;
    }
    
    public int TimeSpent(string a, string b)
    {
        DateTime StartT = Convert.ToDateTime($"2023-10-13 {a}");
        DateTime EndT = Convert.ToDateTime($"2023-10-13 {b}");

        TimeSpan dateDiff = EndT - StartT;
        int diffHoures = dateDiff.Hours;
        int diffMinute = dateDiff.Minutes;
        
        return diffMinute + diffHoures * 60;
    }
    
}