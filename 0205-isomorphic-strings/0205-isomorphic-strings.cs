public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        if(s.Length!=t.Length) return false;

        Dictionary<char,char> MapS=new Dictionary<char,char>();
        Dictionary<char,char> MapT=new Dictionary<char,char>();

        for(int i=0;i<s.Length;i++)
        {

        char c1=s[i];
        char c2=t[i];

        if(MapS.ContainsKey(c1))
        {
            if(MapS[c1]!=c2)
            return false;
        }else
        {
            MapS[c1]=c2;
        }
        if(MapT.ContainsKey(c2))
        {
             if(MapT[c2]!=c1)
            return false;
        }else
        {
            MapT[c2]=c1;
        }
        
        }
        return true;
    }
}