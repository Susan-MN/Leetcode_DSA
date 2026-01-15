public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        Dictionary<char,int> set=new Dictionary<char,int>();
        foreach(char c in magazine)
        {
           if(!set.ContainsKey(c))
           {
            set[c]=1;
           }else

           {
            set[c]++;
           }
        }
        foreach(char c in ransomNote)
        {
            if(!set.ContainsKey(c)||set[c]==0)
            return false;
            set[c]--;
           
        }
       
        return true;
    }
    
}