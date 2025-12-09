public class Solution {
    public string MergeAlternately(string word1, string word2) {

        StringBuilder sb=new StringBuilder();
       
        int i=0;
        int j=0;
        int n1=word1.Length ;
        int n2=word2.Length ;
        while(i<n1 || j<n2)
        {
            if(i<n1)
            {
            sb.Append(word1[i++]);
            }
            if(j<n2)
            {
            sb.Append(word2[j++]);
            }
           
            
        }
        return sb.ToString();
    }
}