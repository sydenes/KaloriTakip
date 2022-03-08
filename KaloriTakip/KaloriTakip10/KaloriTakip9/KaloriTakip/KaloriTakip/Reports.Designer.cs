namespace KaloriTakip
{
    partial class DailyReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDailyCalories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDailyCalories
            // 
            this.chartDailyCalories.BackColor = System.Drawing.Color.Aquamarine;
            chartArea1.Name = "ChartArea1";
            this.chartDailyCalories.ChartAreas.Add(chartArea1);
            this.chartDailyCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDailyCalories.Legends.Add(legend1);
            this.chartDailyCalories.Location = new System.Drawing.Point(0, 0);
            this.chartDailyCalories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDailyCalories.Name = "chartDailyCalories";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kalori";
            series1.XValueMember = "a";
            series1.YValueMembers = "b";
            this.chartDailyCalories.Series.Add(series1);
            this.chartDailyCalories.Size = new System.Drawing.Size(763, 434);
            this.chartDailyCalories.TabIndex = 2;
            this.chartDailyCalories.Text = "chart1";
            title1.Name = "Öğün Kalori Grafiği";
            title1.Text = "Öğün Kalori Grafiği";
            this.chartDailyCalories.Titles.Add(title1);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(77, 21);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(113, 22);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // DailyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 434);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.chartDailyCalories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DailyReports";
            this.Text = "Totals";
            this.Load += new System.EventHandler(this.Totals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyCalories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyCalories;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}