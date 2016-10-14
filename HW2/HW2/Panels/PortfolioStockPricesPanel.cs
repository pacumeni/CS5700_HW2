using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using HW2.Forms;

namespace HW2.Panels
{
    public class PortfolioStockPricesPanel : InformationPanel
    {
        // This is a Portfolio Stock Prices Panel
        Stock pricesStock = new Stock();
        string direction;
        string stockToMonitor;
        TableForm tableToAddTo = new TableForm();
        
        public PortfolioStockPricesPanel(string name)
        {
            stockToMonitor = name;
        }
        // It should show a table containing one row per symbol
        // each row must include: today's opening price, Current price,
        // direction (</> last price), bid price, ask price, ask size
        
        // When creating a new portfolio stock prices panel, user will need
        // to specify which symbols from portfolio it will display.
        
        // user must determine betwenn stock's open price or previous close price
        public void Display()
        {
            Console.WriteLine("Portfolio Stock Price: ");
            Console.WriteLine("stock Symbol = " + pricesStock.stockSymbol);
            Console.Write("stock Opening Price: " + pricesStock.todayOpenPrice);
            Console.Write(" Current Price: " + pricesStock.currentPrice);
            Console.Write(" Direction: " + direction);
            Console.Write(" Bid Price: " + pricesStock.bidPrice);
            Console.Write(" Ask Price: " + pricesStock.askPrice);
            Console.Write(" Volume Sold Today: " + pricesStock.volumeSoldToday);
            
        }

        public string Direction(Stock newStock, Stock oldStock)
        {
            return (newStock.currentPrice > oldStock.currentPrice) ? "up" : "down";
        }
        
        public void updateStock(Stock stock)
        {
            if (stockToMonitor == stock.stockSymbol)
            {
                tableToAddTo.clearTable();
                direction = Direction(stock, pricesStock);
                pricesStock = stock;
                Display();
                tableToAddTo.updateTable(stock, direction);
            }
        }
    }
}
