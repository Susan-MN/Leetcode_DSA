public class Solution {
    public int SingleNumber(int[] nums) {

        Array.Sort(nums);
        if(nums.Length==1)
        {
            return nums[0];
        }
       for(int i=0;i<nums.Length-1;i=i+2)
       {
        
            if(nums[i] != nums[i+1]){
                return nums[i];
                
            }
       } 
       return nums[nums.Length - 1];
    }
}