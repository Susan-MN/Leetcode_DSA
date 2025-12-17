public class Solution {
    public int MostFrequentEven(int[] nums) {
        int max=0;
         int answer=-1;
        Dictionary<int,int> freq=new Dictionary<int,int>();

        foreach(int n in nums)
        {
            if(n%2==0)
            {
            if(!freq.ContainsKey(n)) freq[n]=1;
            else freq[n]++;
            }
        }

        foreach(var kvp in freq)
        {
            if(kvp.Value>max)
            {
               max=kvp.Value;
               answer=kvp.Key;
            }
            if(kvp.Value==max)
            {
                answer=Math.Min(answer,kvp.Key);
            }
        }
        return answer;
    }
}