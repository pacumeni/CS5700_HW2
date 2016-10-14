
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using HW2.Panels;

namespace Common
{
    public class StockPortfolio : Dictionary<String, Stock>
    {
        private List<InformationPanel> subscriberList;
        Stock stock;

        public StockPortfolio()
        {
            subscriberList = new List<InformationPanel>();
        }

        public void addSubscriber(InformationPanel subscriber)
        {
                subscriberList.Add(subscriber);
        }
        
        public void unSubscribe(InformationPanel subscriber)
        {
            subscriberList.Remove(subscriber);
        }
        
        public void notifySubscribers()
        {
            foreach (var sub in subscriberList)
                sub.updateStock(stock);
        }
        
        private void stockChanged()
        {
            notifySubscribers();
        }

        // Creates a new stock if message is not null;
        public void Update(TickerMessage message)
        {
            if (message == null) return;

            //if (ContainsKey(message.Symbol))
            //    this[message.Symbol].Update(message);
            stock = new Stock();
            stock.Update(message);
            stockChanged();
        }
    }
}