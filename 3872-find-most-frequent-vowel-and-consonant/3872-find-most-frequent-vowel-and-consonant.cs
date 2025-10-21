public class Solution {
    public int MaxFreqSum(string s) {
        
        Dictionary<char,int> freq=new Dictionary<char,int>();
        HashSet<char> set=new HashSet<char>{'a','e','i','o','u'};
        int sum=0;
        int maxVowel=0;
        int MaxCons=0;
        char[] str=s.ToCharArray();
        foreach(char c in str)
        {
            if(!freq.ContainsKey(c))
            {
                freq[c]=1;
            }else
            {
                
                freq[c]++;
            }
        }

        foreach(var kvp in freq)
        {
            if(set.Contains(kvp.Key))
            {
                maxVowel=Math.Max(maxVowel,kvp.Value);
            }
            else
            {
                 MaxCons=Math.Max(MaxCons,kvp.Value);
            }
        }  
        return maxVowel+MaxCons;  
    }
}