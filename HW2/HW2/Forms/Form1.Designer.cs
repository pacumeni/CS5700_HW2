using System;

namespace HW2
{
    partial class PortfolioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortfolioSetup = new System.Windows.Forms.ListBox();
            this.WatchList = new System.Windows.Forms.ListBox();
            this.AddToWatchList = new System.Windows.Forms.Button();
            this.RemoveFromWatchList = new System.Windows.Forms.Button();
            this.ViewStart = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadPortfolio = new System.Windows.Forms.Button();
            this.SavePortfolio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartsAndGraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPriceGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysOpenPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesterdayClosePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortfolioSetup
            // 
            this.PortfolioSetup.FormattingEnabled = true;
            this.PortfolioSetup.Location = new System.Drawing.Point(12, 21);
            this.PortfolioSetup.Name = "PortfolioSetup";
            this.PortfolioSetup.Size = new System.Drawing.Size(127, 147);
            this.PortfolioSetup.TabIndex = 1;
            // 
            // WatchList
            // 
            this.WatchList.FormattingEnabled = true;
            this.WatchList.Location = new System.Drawing.Point(238, 21);
            this.WatchList.Name = "WatchList";
            this.WatchList.Size = new System.Drawing.Size(133, 147);
            this.WatchList.TabIndex = 2;
            // 
            // AddToWatchList
            // 
            this.AddToWatchList.Location = new System.Drawing.Point(145, 60);
            this.AddToWatchList.Name = "AddToWatchList";
            this.AddToWatchList.Size = new System.Drawing.Size(85, 23);
            this.AddToWatchList.TabIndex = 3;
            this.AddToWatchList.Text = "Add >>";
            this.AddToWatchList.UseVisualStyleBackColor = true;
            this.AddToWatchList.Click += new System.EventHandler(this.AddToWatchList_Click);
            // 
            // RemoveFromWatchList
            // 
            this.RemoveFromWatchList.Location = new System.Drawing.Point(145, 113);
            this.RemoveFromWatchList.Name = "RemoveFromWatchList";
            this.RemoveFromWatchList.Size = new System.Drawing.Size(85, 23);
            this.RemoveFromWatchList.TabIndex = 4;
            this.RemoveFromWatchList.Text = "<< Remove";
            this.RemoveFromWatchList.UseVisualStyleBackColor = true;
            this.RemoveFromWatchList.Click += new System.EventHandler(this.RemoveFromWatchList_Click);
            // 
            // ViewStart
            // 
            this.ViewStart.Location = new System.Drawing.Point(286, 242);
            this.ViewStart.Name = "ViewStart";
            this.ViewStart.Size = new System.Drawing.Size(85, 24);
            this.ViewStart.TabIndex = 5;
            this.ViewStart.Text = "View  Start";
            this.ViewStart.UseVisualStyleBackColor = true;
            this.ViewStart.Click += new System.EventHandler(this.ViewStart_Click);
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(238, 194);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(133, 20);
            this.Response.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "End Point";
            // 
            // LoadPortfolio
            // 
            this.LoadPortfolio.Location = new System.Drawing.Point(28, 194);
            this.LoadPortfolio.Name = "LoadPortfolio";
            this.LoadPortfolio.Size = new System.Drawing.Size(92, 23);
            this.LoadPortfolio.TabIndex = 8;
            this.LoadPortfolio.Text = "Load Portfolio";
            this.LoadPortfolio.UseVisualStyleBackColor = true;
            this.LoadPortfolio.Click += new System.EventHandler(this.LoadPortfolio_Click);
            // 
            // SavePortfolio
            // 
            this.SavePortfolio.Location = new System.Drawing.Point(28, 242);
            this.SavePortfolio.Name = "SavePortfolio";
            this.SavePortfolio.Size = new System.Drawing.Size(92, 23);
            this.SavePortfolio.TabIndex = 9;
            this.SavePortfolio.Text = "Save Portfolio";
            this.SavePortfolio.UseVisualStyleBackColor = true;
            this.SavePortfolio.Click += new System.EventHandler(this.SavePortfolio_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartsAndGraphsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartsAndGraphsToolStripMenuItem
            // 
            this.chartsAndGraphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPriceGraphToolStripMenuItem});
            this.chartsAndGraphsToolStripMenuItem.Name = "chartsAndGraphsToolStripMenuItem";
            this.chartsAndGraphsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.chartsAndGraphsToolStripMenuItem.Text = "Charts And Graphs";
            // 
            // addPriceGraphToolStripMenuItem
            // 
            this.addPriceGraphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todaysOpenPriceToolStripMenuItem,
            this.yesterdayClosePriceToolStripMenuItem});
            this.addPriceGraphToolStripMenuItem.Name = "addPriceGraphToolStripMenuItem";
            this.addPriceGraphToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addPriceGraphToolStripMenuItem.Text = "Add Price Graph";
            // 
            // todaysOpenPriceToolStripMenuItem
            // 
            this.todaysOpenPriceToolStripMenuItem.Name = "todaysOpenPriceToolStripMenuItem";
            this.todaysOpenPriceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.todaysOpenPriceToolStripMenuItem.Text = "Today\'s Open Price";
            // 
            // yesterdayClosePriceToolStripMenuItem
            // 
            this.yesterdayClosePriceToolStripMenuItem.Name = "yesterdayClosePriceToolStripMenuItem";
            this.yesterdayClosePriceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.yesterdayClosePriceToolStripMenuItem.Text = "Yesterday Close Price";
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 293);
            this.Controls.Add(this.SavePortfolio);
            this.Controls.Add(this.LoadPortfolio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.ViewStart);
            this.Controls.Add(this.RemoveFromWatchList);
            this.Controls.Add(this.AddToWatchList);
            this.Controls.Add(this.WatchList);
            this.Controls.Add(this.PortfolioSetup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PortfolioForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }       

        #endregion

        private System.Windows.Forms.ListBox PortfolioSetup;
        private System.Windows.Forms.ListBox WatchList;
        private System.Windows.Forms.Button AddToWatchList;
        private System.Windows.Forms.Button RemoveFromWatchList;
        private System.Windows.Forms.Button ViewStart;
        private System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadPortfolio;
        private System.Windows.Forms.Button SavePortfolio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chartsAndGraphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPriceGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaysOpenPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesterdayClosePriceToolStripMenuItem;
    }
}