using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2.Forms
{
    public partial class TableForm : Form
    {
        
        public TableForm()
        {
            InitializeComponent();
            this.Show();
        }

        public void updateTable(Stock stock, string direction)
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate
                {
                    this.dataGridView1.Rows.Add(stock.stockSymbol, stock.todayOpenPrice, stock.currentPrice, direction, stock.bidPrice, stock.askPrice);
                }));
        }

        public void clearTable()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate { this.dataGridView1.Rows.Clear(); }));
        }
    }
}
