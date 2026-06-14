public class Solution {
    public void SortColors(int[] nums) {
    {    
     for(int i=0;i<nums.Length;i++)
     {
        int min=i;
        for(int j=i+1;j<nums.Length;j++)
        {
            if(nums[min]>nums[j])
            {
                min=j;
            
            }
        }
        int temp=nums[i];
        nums[i]=nums[min];
        nums[min]=temp;
            
        
     }  
    }
   
    }
}