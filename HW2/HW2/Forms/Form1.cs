using System;
using System.Windows.Forms;
using Common;
using System.Net;
using System.IO;
using HW2.Panels;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace HW2
{
    public partial class PortfolioForm : Form
    {

        public StockPortfolio portfolio;
        public Communicator communicator;
        public IPEndPoint simulatorEndPoint;
        public PortfolioForm()
        {
            InitializeComponent();
            portfolio = new StockPortfolio();
            populatePortfolioSetup();
        }

        public List<object> portfolioWatchList
        {
            get {
                List<object> watchlistItems = new List<object>();
                foreach (var item in WatchList.Items)
                    watchlistItems.Add(item);
                return watchlistItems;
            }
        }

        public void populatePortfolioSetup()
        {
            string line;
            StreamReader file = new StreamReader("CompanyList.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                PortfolioSetup.Items.Add(words[0]);
            }

            file.Close();
        }

        private void AddToWatchList_Click(object sender, EventArgs e)
        {
            string a = PortfolioSetup.SelectedItem.ToString();
            WatchList.Items.Add(a);
        }

        private void RemoveFromWatchList_Click(object sender, EventArgs e)
        {
            string a = WatchList.SelectedItem.ToString();
            WatchList.Items.Remove(a);            
        }

        private void ViewStart_Click(object sender, EventArgs e)
        {
            foreach (var item in WatchList.Items)
                portfolio.Add(item.ToString(), new Stock() { });


            simulatorEndPoint = EndPointParser.Parse(Response.Text);
            communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };

            PanelOptions po = new PanelOptions(this);
            po.Show();
            this.Hide();


        }

        private void SavePortfolio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                using (StreamWriter file = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var item in WatchList.Items)
                        file.WriteLine(item);
                }
            }
        }

        private void LoadPortfolio_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        WatchList.Items.Add(line);
                    }

                    file.Close();
                }
            }
        }
    }
}
