using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        string temp = ConvertToK(n,k);
        
        string[] digits = temp.Split('0');

        if(digits.Length > 0)
        {
            foreach (var prime in digits)
            {
                if (!string.IsNullOrEmpty(prime) && IsPrime(long.Parse(prime)))
                {
                    answer++;
                }
            }
        }

        return answer;
    }
    
    public string ConvertToK(int n, int k)
    {
        string baseK = "";
        while (n > 0)
        {
            int remainder = n % k;
            baseK = remainder + baseK;
            n /= k;
        }
        return baseK;
    }
    
    public bool IsPrime(long number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (long i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
}