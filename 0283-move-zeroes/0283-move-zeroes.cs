public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int insertposition=0;

        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
        {
            nums[insertposition]=nums[i];
            insertposition++;

        }
        }
        while(insertposition<nums.Length)
        {
            nums[insertposition++]=0;
        }
        
        
    }
}