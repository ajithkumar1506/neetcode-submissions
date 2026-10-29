public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 1){
            return 0;
        }
        
        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (int price in prices) {
            if (price < minPrice) {
                minPrice = price;
            }
            else {
                int profit = price - minPrice;
                if (profit > maxProfit) {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}
