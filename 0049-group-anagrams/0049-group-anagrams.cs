public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> map=new Dictionary<string,List<string>>();
        foreach(string word in strs)
        {
            char[] arr=word.ToCharArray();
            Array.Sort(arr);
            string key=new string(arr);
            if(!map.ContainsKey(key))
            {
                map[key]=new List<string>(){word};
            }else{
                map[key].Add(word);
            }
                
            
        }
        return map.Values.ToList<IList<string>>();
    }
}