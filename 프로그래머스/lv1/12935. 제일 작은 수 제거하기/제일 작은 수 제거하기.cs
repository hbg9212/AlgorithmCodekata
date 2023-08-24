public class Solution {
    public int[] solution(int[] arr) {
        int index = arr.Length;
        int[] answer;
        
        if (index == 1)
        {
            answer = new int[] {-1};
        }
        else
        {
            answer = new int[--index]; 
            int temp = arr[0];
            for (int i = 0; i < index; i++)
            {
                if(temp > arr[i +1])
                {
                    temp = arr[i+1];
                }
            }
            index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > temp)
                {
                    answer[index++] = arr[i];     
                }
            }
        }
                
        return answer;
    }
}