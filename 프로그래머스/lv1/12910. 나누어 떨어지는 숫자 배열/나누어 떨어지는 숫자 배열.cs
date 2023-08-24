public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer;
        int c = 0;
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i]%divisor == 0)
                c++;
        }
        if(c == 0)
        {
            c++;
            answer = new int[] {-1};
        }
        else
        {
            answer = new int[c];
            c = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]%divisor == 0)
                    answer[c++] = arr[i];
            }
        }
        
        for(int i = 0; i < c; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < c; j++)
            {
                if (answer[j] < answer[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = answer[i];
            answer[i] = answer[minIndex];
            answer[minIndex] = temp;
        }
        
        
        return answer;
    }
}