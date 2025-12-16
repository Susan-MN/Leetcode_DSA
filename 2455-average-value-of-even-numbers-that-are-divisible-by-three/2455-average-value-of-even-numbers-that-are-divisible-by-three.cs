public class Solution {
    public int AverageValue(int[] nums) {
        int sum=0;
        int count=0;
        foreach(int n in nums)
        {
            if(n%2==0 && n%3==0)
            {
                sum+=n;
                count++;
            }
        }
        
        return count==0?0: sum/count;
        
    }
}