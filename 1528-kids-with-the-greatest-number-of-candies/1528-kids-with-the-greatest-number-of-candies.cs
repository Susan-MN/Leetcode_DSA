public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int maxCandies=candies.Max();
        bool[] result=new bool[candies.Length];
        for(int i=0;i<candies.Length;i++)
        {
          result[i]=(candies[i]+extraCandies)>=maxCandies;
        }
        return result;
    }
}