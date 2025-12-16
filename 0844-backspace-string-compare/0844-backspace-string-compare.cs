public class Solution {
    public bool BackspaceCompare(string s, string t) {
    return process(s)==process(t);
    }
        private string process(string str)
        {
            Stack<char> stack=new Stack<char>();
            foreach(char c in str)
            {
                if(c=='#')
                {
                    if(stack.Count>0)
                    {
                        stack.Pop();
                    }
                    
                }else
                {
                    stack.Push(c);
                }
            }
            return new string(stack.Reverse().ToArray());
        }
        

     
    
}