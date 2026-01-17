public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        HashSet<int> set=new HashSet<int>(nums1);
        HashSet<int> result=new HashSet<int>();
        foreach(int n in nums2)
        {
            if(set.Contains(n))
            {
                result.Add(n);
            }
        }
        return result.ToArray();
    }
}