using System;

public class Solution {
    public int answer = 0;
    public bool[] boolArray;
    
    public int solution(int k, int[,] dungeons) {

        boolArray = new bool[dungeons.GetLength(0)];
        Function(k,dungeons,0);

        return answer;
    }
    
    public void Function(int k, int[,] dungeons, int count)
    {
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (!boolArray[i] && dungeons[i, 0] <= k)
            {
                boolArray[i] = true;
                Function(k - dungeons[i, 1], dungeons, count + 1);
                boolArray[i] = false;
            }
        }
        
        answer = count > answer ? count : answer;
    }
}