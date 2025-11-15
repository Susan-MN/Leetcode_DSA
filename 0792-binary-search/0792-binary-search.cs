public class Solution {
    public int Search(int[] nums, int target) {
        
        int i=0;
        int n=nums.Length-1;
        while(i<n)
        {
            var m=(i+n)/2;
            if(nums[m]>=target)
            {
                n=m;
            }else{
                i=m+1;
            }
          
        }
          return nums[i]==target?i:-1;

    }
}