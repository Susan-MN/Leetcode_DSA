public class Solution {
    public int PivotIndex(int[] nums) {
        
    int rightSum=0;
    foreach(int n in nums)
    {
        rightSum+=n;
    }

    int leftSum=0;
    for(int i=0;i<nums.Length;i++)
    {
        rightSum-=nums[i];

        if(leftSum==rightSum)
        {
            return i;
        }
        leftSum+=nums[i];
    }

        return -1;

    }
}