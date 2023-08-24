using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long re = money;
        int index = 0;
        
        while (index < count)
        {
            re -= price * ++index;   
        }
        
        return re > 0 ? 0 : re * -1;
    }
}