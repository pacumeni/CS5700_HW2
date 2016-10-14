using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW2.Panels;

namespace HW2
{
    public partial class PanelOptions : Form
    {
        public PanelOptions()
        {
            InitializeComponent();
        }

        private PortfolioForm portfolioForm = null;

        public PanelOptions(Form callFromPortfolioForm)
        {
            portfolioForm = callFromPortfolioForm as PortfolioForm;
            InitializeComponent();
            ToolStripMenuItem[] items = new ToolStripMenuItem[this.portfolioForm.portfolioWatchList.Count()];


            // These next lines are for creating a list of menu items based on what the user input for stocks to monitor.
            for ( int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = this.portfolioForm.portfolioWatchList[i] + "_Open_PriceGraph_ToolStripMenuItem";
                items[i].Text = string.Format("{0}", this.portfolioForm.portfolioWatchList[i]);
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            priceGraphOpenPriceToolStripMenuItem.DropDownItems.AddRange(items);

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = this.portfolioForm.portfolioWatchList[i] + "_Close_PriceGraph_ToolStripMenuItem";
                items[i].Text = string.Format("{0}", this.portfolioForm.portfolioWatchList[i]);
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            PriceGraphClosePriceToolStripMenuItem.DropDownItems.AddRange(items);

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = this.portfolioForm.portfolioWatchList[i] + "_Open_PricePanel_ToolStripMenuItem";
                items[i].Text = string.Format("{0}", this.portfolioForm.portfolioWatchList[i]);
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            pricePanelOpenPriceToolStripMenuItem.DropDownItems.AddRange(items);

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = this.portfolioForm.portfolioWatchList[i] + "_Close_PricePanel_ToolStripMenuItem";
                items[i].Text = string.Format("{0}", this.portfolioForm.portfolioWatchList[i]);
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            pricePanelClosePriceToolStripMenuItem.DropDownItems.AddRange(items);

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = this.portfolioForm.portfolioWatchList[i] + "_Open_VolumeGraph_ToolStripMenuItem";
                items[i].Text = string.Format("{0}", this.portfolioForm.portfolioWatchList[i]);
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            volumeGraphOpenPriceToolStripMenuItem.DropDownItems.AddRange(items);

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = this.portfolioForm.portfolioWatchList[i] + "_Close_VolumeGraph_ToolStripMenuItem";
                items[i].Text = string.Format("{0}", this.portfolioForm.portfolioWatchList[i]);
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }
            volumeGraphClosePriceToolStripMenuItem.DropDownItems.AddRange(items);
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            string[] getInstanceType = clickedItem.Name.Split('_');
            if (getInstanceType[2] == "PriceGraph")
            {
                if (getInstanceType[1] == "open")
                {
                    IndividualStockPriceGraph ispg = new IndividualStockPriceGraph(clickedItem.Text, "open");
                    this.portfolioForm.portfolio.addSubscriber(ispg);
                } else
                {
                    IndividualStockPriceGraph ispg = new IndividualStockPriceGraph(clickedItem.Text, "close");
                    this.portfolioForm.portfolio.addSubscriber(ispg);
                }
            } else if (getInstanceType[2] == "PricePanel")
            {

                PortfolioStockPricesPanel spg = new PortfolioStockPricesPanel(clickedItem.Text);
                this.portfolioForm.portfolio.addSubscriber(spg);         
            } else
            {
                if (getInstanceType[1] == "Open")
                {
                    IndividualStockVolumeGraph isvg = new IndividualStockVolumeGraph(clickedItem.Text, "open");
                    this.portfolioForm.portfolio.addSubscriber(isvg);
                } else
                {
                    IndividualStockVolumeGraph isvg = new IndividualStockVolumeGraph(clickedItem.Text, "close");
                    this.portfolioForm.portfolio.addSubscriber(isvg);
                }

            }
            
            this.portfolioForm.communicator.Start();
        }
    }
}
