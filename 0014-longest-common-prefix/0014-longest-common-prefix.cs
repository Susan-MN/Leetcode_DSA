public class Solution {
    public string LongestCommonPrefix(string[] strs) {
          StringBuilder result=new StringBuilder();
          Array.Sort(strs);
          char[] first=strs[0].ToCharArray();
          char[] last=strs[strs.Length-1].ToCharArray();

          for(int i=0;i<first.Length;i++)
          {
            if(first[i]!=last[i])
            {
                break;
            }
            result.Append(first[i]);
     
          }
          return result.ToString();
    }
}