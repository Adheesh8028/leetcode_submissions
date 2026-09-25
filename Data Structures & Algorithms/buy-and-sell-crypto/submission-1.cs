public class Solution {
    public int MaxProfit(int[] prices) {
        
        int minPrice = prices[0];
        int maxPrice = 0;

        for(int i = 1; i < prices.Length; i++){
            if(minPrice > prices[i]){
                minPrice = prices[i];
            }
            
            int profit = prices[i] - minPrice;

            maxPrice = Math.Max(maxPrice, profit);
        }
        return maxPrice;

    }
}
