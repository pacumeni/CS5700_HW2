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
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
            this.Show();
        }

        public void updateLabel(string newLabel, double price)
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate { label1.Text = string.Format("{0}: ", newLabel); }));
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate { label2.Text = string.Format("{0}", price); }));
        }

        public void updateChart(double x, double y)
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate { chart1.Series["Series1"].Points.AddXY(x, y); }));
        }

        public void clearChart()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate { chart1.Series["Series1"].Points.Clear(); }));
        }
    }
}
