public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int n=nums.Length;
        int left=0;
        int right=nums.Length-1;
         int[] result=new int[n];
        for(int i=n-1;i>=0;i--)
        {
            if(Math.Abs(nums[left])>Math.Abs(nums[right]))
            {
                result[i]=nums[left]*nums[left];
                left++;
            }else
            {
                result[i]=nums[right]*nums[right];
                right--;
            }

            
        }
       return result;
    }
     
}