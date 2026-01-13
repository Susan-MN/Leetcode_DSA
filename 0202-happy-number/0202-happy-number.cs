public class Solution {
    public bool IsHappy(int n) {
        
        HashSet<int> set=new HashSet<int>();

        while(n!=1)
        {
            if(set.Contains(n))
            {
                return false;
            }
            set.Add(n);
            n=sumOfSquareOfDigits(n);
        }
       return true;
    }
    private int sumOfSquareOfDigits(int n)
    {
        int sum=0;
         while(n>0)
        {
            int digit=n%10;
             sum+=digit*digit;
            n/=10;            
        }
        return sum;
    }
}