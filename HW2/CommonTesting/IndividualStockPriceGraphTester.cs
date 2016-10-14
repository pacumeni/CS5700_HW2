using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using HW2.Panels;
using Common;
using System;

namespace CommonTesting
{
    [TestClass]
    public class IndividualStockPriceGraphTester
    {
        [TestMethod]
        public void IndividualStockPriceGraph_CreateInstanceCreateStopWatches()
        {
            IndividualStockPriceGraph stockPriceGraph = new IndividualStockPriceGraph("ABCD", "open");
            Assert.IsInstanceOfType(stockPriceGraph, typeof(IndividualStockPriceGraph));            
            Assert.IsNotNull(stockPriceGraph);
        }

        [TestMethod]
        public void IndividualStockPriceGraph_updateOnlyNamedStock()
        {
            StockPortfolio portfolio = new StockPortfolio();
            IndividualStockPriceGraph stockPriceGraph = new IndividualStockPriceGraph("ABCD", "open");

            portfolio.addSubscriber(stockPriceGraph);

            TickerMessage m1 = new TickerMessage()
            {
                Symbol = "ABCD",
                MessageTimestamp = DateTime.Now,
                OpeningPrice = 1001,
                PreviousClosingPrice = 1002,
                CurrentPrice = 1003,
                AskPrice = 1004,
                BidPrice = 1005,
                CurrentVolume = 1006,
                AverageVolume = 1007
            };

            TickerMessage m2 = new TickerMessage()
            {
                Symbol = "EFGH",
                MessageTimestamp = DateTime.Now,
                OpeningPrice = 1011,
                PreviousClosingPrice = 1022,
                CurrentPrice = 1033,
                AskPrice = 1044,
                BidPrice = 1055,
                CurrentVolume = 1066,
                AverageVolume = 1077
            };

            portfolio.Update(m1);
            Assert.AreEqual(1003, stockPriceGraph.getCurrentPrice());

            portfolio.Update(m2);
            Assert.AreEqual(1003, stockPriceGraph.getCurrentPrice());
        }

        [TestMethod]
        public void IndividualStockPriceGraph_multipleInstanceTest()
        {
            StockPortfolio portfolio = new StockPortfolio();
            IndividualStockPriceGraph stockPriceGraph = new IndividualStockPriceGraph("ABCD", "open");
            IndividualStockPriceGraph stockPriceGraph2 = new IndividualStockPriceGraph("EFGH", "close");

            portfolio.addSubscriber(stockPriceGraph);
            portfolio.addSubscriber(stockPriceGraph2);

            TickerMessage m1 = new TickerMessage()
            {
                Symbol = "ABCD",
                MessageTimestamp = DateTime.Now,
                OpeningPrice = 1001,
                PreviousClosingPrice = 1002,
                CurrentPrice = 1003,
                AskPrice = 1004,
                BidPrice = 1005,
                CurrentVolume = 1006,
                AverageVolume = 1007
            };

            TickerMessage m2 = new TickerMessage()
            {
                Symbol = "EFGH",
                MessageTimestamp = DateTime.Now,
                OpeningPrice = 1011,
                PreviousClosingPrice = 1022,
                CurrentPrice = 1033,
                AskPrice = 1044,
                BidPrice = 1055,
                CurrentVolume = 1066,
                AverageVolume = 1077
            };

            portfolio.Update(m1);
            Assert.AreEqual(1003, stockPriceGraph.getCurrentPrice());

            portfolio.Update(m2);
            Assert.AreEqual(1033, stockPriceGraph2.getCurrentPrice());
        }
    }
}
