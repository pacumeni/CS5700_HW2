using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Stock
    {
        public string stockSymbol { get; set; }
        public double todayOpenPrice { get; set; }
        public double previousDayClosePrice { get; set; }
        public double currentPrice { get; set; }
        public double bidPrice { get; set; }
        public double askPrice { get; set; }
        public int volumeSoldToday { get; set; }
        public double tenDayAverage { get; set; }

        public void Update(TickerMessage message)
        {
            stockSymbol = message.Symbol;
            todayOpenPrice = message.OpeningPrice;
            previousDayClosePrice = message.PreviousClosingPrice;
            currentPrice = message.CurrentPrice;
            bidPrice = message.BidPrice;
            askPrice = message.AskPrice;
            volumeSoldToday = message.CurrentVolume;
            tenDayAverage = message.AverageVolume;
        }
    }
}