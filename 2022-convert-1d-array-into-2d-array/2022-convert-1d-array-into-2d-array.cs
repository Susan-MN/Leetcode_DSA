public class Solution 
{
    public int[][] Construct2DArray(int[] original, int m, int n) 
    {
        if (m * n != original.Length)
        {
            return new int[0][];
        }

        var result = new int[m][];
        List<int> res = [];
        var index = 0;
        var saveN = n;

        for(int i = 0; i < m; i++)
        {
            for(int j = index; j < original.Length;)
            {
                if(saveN != 0)
                {
                    res.Add(original[index]);
                    saveN--;
                    index++;
                }
                else
                    break;
            }

            saveN = n;
            result[i] = res.ToArray();
            res = [];
        }

        return result;
    }
}