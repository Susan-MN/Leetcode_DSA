public class Solution {
    public int DifferenceOfSum(int[] nums) {
        
        int sum=0;
        int digitsum=0;

        foreach(int n in nums)
        {
            sum+=n;
        }
        

        foreach(int n in nums)
        {
            int k=n;
            while(k>0)
            {
                int j=k%10;
                k/=10;
                digitsum+=j;
            }
        }
        return sum-digitsum;
    }

}