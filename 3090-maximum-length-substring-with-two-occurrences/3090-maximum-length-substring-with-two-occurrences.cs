public class Solution {
    public int MaximumLengthSubstring(string s) {
        int left=0;
        int maxLen=0;
        Dictionary<char,int>freq=new Dictionary<char,int>();
        for (int right=0;right<s.Length;right++)
        {
             if(!freq.ContainsKey(s[right]))
            {
                freq[s[right]]=0;
            }
            freq[s[right]]++;
           while(freq[s[right]]>2)
           {
            char leftChar=s[left];
            freq[leftChar]--;
            left++;
           }
            maxLen=Math.Max(maxLen,right-left+1);
       
        }
       return maxLen;
    }
    
}