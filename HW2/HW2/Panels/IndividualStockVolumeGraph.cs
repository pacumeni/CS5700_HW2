using System;
using Common;
using System.Diagnostics;
using HW2.Forms;

namespace HW2.Panels
{
    public class IndividualStockVolumeGraph : InformationPanel
    {
        // This graph shows the current stock VOLUME for the day in 1-minute intervals over the last hour
        Stopwatch minuteStopwatch;
        Stopwatch hourStopwatch;
        Stock priceGraph;
        string stockToMonitor;
        GraphForm vG;
        int count;
        string whichToDisplay;

        public IndividualStockVolumeGraph(string name, string whichPriceDisplay)
        {
            minuteStopwatch = Stopwatch.StartNew();
            hourStopwatch = Stopwatch.StartNew();
            priceGraph = new Stock();
            vG = new GraphForm();
            stockToMonitor = name;
            whichToDisplay = whichPriceDisplay;
        }

        public void Display()
        {
            Console.WriteLine("Individual Stock Volume Graph");
            Console.WriteLine("symbol = " + priceGraph.stockSymbol);
            if (whichToDisplay == "open")
                Console.WriteLine("Stock's Open Price " + priceGraph.todayOpenPrice);
            else
                Console.WriteLine("Stock's Close Price " + priceGraph.previousDayClosePrice);
            Console.WriteLine("stock volume = " + priceGraph.volumeSoldToday);

            if (whichToDisplay == "open")
                vG.updateLabel(whichToDisplay, priceGraph.todayOpenPrice);
            else
                vG.updateLabel(whichToDisplay, priceGraph.previousDayClosePrice);

            vG.updateChart(count, priceGraph.volumeSoldToday);
            count++;
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
                    vG.clearChart();
                    hourStopwatch.Restart();
                }
            }
        }
    }
}
