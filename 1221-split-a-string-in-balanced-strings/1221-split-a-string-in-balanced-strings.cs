public class Solution {
    public int BalancedStringSplit(string s) {

        int count=0;
        int left=0;
        int right=0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='R')
            {
                right++;
            }
            if(s[i]=='L')
            {
                left++;
            }
            if(left==right)
            {
                count++;
            }
        }
    return count;
    }
}