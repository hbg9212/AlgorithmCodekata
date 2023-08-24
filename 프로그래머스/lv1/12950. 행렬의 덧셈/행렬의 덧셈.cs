public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = arr1;
        int[] temp = new int[2];
        for(int i = 0; i < arr1.Rank; i++)
        {
            temp[i] = arr1.GetLength(i);
        }
        
        for(int i = 0; i < temp[0]; i++)
        {
            for(int j = 0; j < temp[1]; j++)
            {
                answer[i,j] = answer[i,j] + arr2[i,j];
            }
        }
        
        return answer;
    }
}