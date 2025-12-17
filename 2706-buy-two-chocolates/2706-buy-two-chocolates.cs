public class Solution {
    public int BuyChoco(int[] prices, int money) {
        
        Array.Sort(prices);
        if(prices.Length>=2)
        {
        int balance=(prices[1]+prices[0]);
        if(balance<=money) return money-balance;
        }
        return money;
    }
}