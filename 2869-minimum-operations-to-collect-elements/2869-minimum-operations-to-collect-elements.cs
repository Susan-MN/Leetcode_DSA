public class Solution {
    public int MinOperations(IList<int> nums, int k) {
        
        HashSet<int> Set=new HashSet<int>();
        for(int i=1;i<=k;i++)
        {
            Set.Add(i);
        }
        int count=0;
        for(int i=nums.Count-1;i>=0;i--)
        {
            count++;
            if(Set.Contains(nums[i]))
            {
                Set.Remove(nums[i]);
            
            if(Set.Count==0) break;
            }
        }
        return count;
    }
}