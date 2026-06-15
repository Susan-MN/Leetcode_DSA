public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        
        for(int a=1;a<n;a++)
        {
            if(!a.ToString().Contains('0') && !(n-a).ToString().Contains('0'))
            {
                return new int[] {a,n-a};
            }
        }
        return [0];
    }
}