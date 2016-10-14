using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Diagnostics;
using HW2.Forms;

namespace HW2.Panels
{
    public class IndividualStockPriceGraph : InformationPanel
    {
        // This graph shows current stock price in 1-minute intervals over the last hour
        Stopwatch minuteStopwatch;
        Stopwatch hourStopwatch;        
        Stock priceGraph;
        string stockToMonitor;
        public int count { get; set; }
        GraphForm pG;
        string whichToDisplay;

        public IndividualStockPriceGraph(string name, string whichPriceDisplay)
        {
            minuteStopwatch = Stopwatch.StartNew();
            hourStopwatch = Stopwatch.StartNew();
            priceGraph = new Stock();
            pG = new GraphForm();
            stockToMonitor = name;
            whichToDisplay = whichPriceDisplay;
        }

        public void Display()
        {
            Console.WriteLine("Individual Stock Price Graph");
            Console.WriteLine("stock currentPrice = " + priceGraph.currentPrice);
            if (whichToDisplay == "open")
                Console.WriteLine("Stock's Open Price " + priceGraph.todayOpenPrice);
            else
                Console.WriteLine("Stock's Close Price " + priceGraph.previousDayClosePrice);
            Console.WriteLine("stock volume = " + priceGraph.volumeSoldToday);

            if (whichToDisplay == "open")
                pG.updateLabel(whichToDisplay, priceGraph.todayOpenPrice);
            else
                pG.updateLabel(whichToDisplay, priceGraph.previousDayClosePrice);

            pG.updateChart(count, priceGraph.currentPrice);
            count++;
        }

        public double getCurrentPrice()
        {
            return priceGraph.currentPrice;
        }

        public void updateStock(Stock stock)
        {
            if (stockToMonitor == stock.stockSymbol)
            {
                priceGraph = stock;

                // If a minute is reached, Display current Price
                if (minuteStopwatch.ElapsedMilliseconds > (60 * 1000))
                {
                    Display();
                    minuteStopwatch.Restart();
                }

                // if an hour is reached. Clear, then display new price
                if (hourStopwatch.ElapsedMilliseconds > (60 * 60 * 1000))
                {
                    pG.clearChart();
                    hourStopwatch.Restart();
                }
            }
        }
    }
}
