using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class BuyAndSellStocks
    {
        public BuyAndSellStocks()
        {

        }

        public int MaxProfit(int[] prices)
        {
            int max = int.MinValue;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                //buy on day 1
                int buy = prices[i];
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] = buy;
                    max = Math.Max(max, profit);
                }
            }

            return max;
        }

        public int MaxProfitOptimized(int[] prices)
        {           
            int minValue = prices[0];
            int maxValue = prices[0];
            int maxProfit = 0;

            for(var i = 0; i < prices.Length; i++)
            {
                if(prices[i] < minValue)
                {
                    minValue = prices[i];
                    //consider that max cannot occur before min;
                    maxValue = prices[i];
                }

                if (prices[i] > maxValue)
                {
                    maxValue = prices[i];
                }
                int profit = maxValue - minValue;
                maxProfit = Math.Max(maxProfit, profit);                
            }


            return maxProfit;
        }
    }
}
