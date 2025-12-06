public class Solution {
    public string ReverseWords(string s) {

       char[] arr=s.ToCharArray();
       int left=0;
       int right=0;

       while(right<arr.Length)
       {
        if(arr[right]==' ')
        {
            reverse(arr,left,right-1);
            left=right+1;
        }
        right++;
       } 
       reverse(arr,left,right-1);
        return new string(arr);

    }
    private void reverse(char[] arr,int left,int right)
    {
        while(left<right)
        {
             char temp=arr[left];
            arr[left++]=arr[right];
            arr[right--]=temp;
        }
       
    }
}