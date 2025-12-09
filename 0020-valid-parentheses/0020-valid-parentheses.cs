public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> mystack=new Stack<char>();

        Dictionary<char,char> dic = new(){
            {'(',')'},
            {'{','}'},
            {'[',']'}
        } ;


        for(int i=0;i<s.Length;i++)
        {
            if(dic.Keys.Contains(s[i]))
            {
                mystack.Push(s[i]);
            }
            else if(mystack.Count>0 && s[i]==dic[mystack.Peek()])
            {
                
                mystack.Pop(); 

            }
            else{
                return false;
            }
            
        }
        return mystack.Count==0;
    }
}