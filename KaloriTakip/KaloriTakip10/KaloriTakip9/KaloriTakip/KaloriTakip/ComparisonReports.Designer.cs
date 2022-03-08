
namespace KaloriTakip
{
    partial class ComparisonReports
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAllReports = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbtnWeekly = new System.Windows.Forms.RadioButton();
            this.rbtnMonthly = new System.Windows.Forms.RadioButton();
            this.rbtnByMeal = new System.Windows.Forms.RadioButton();
            this.rbtnByCategory = new System.Windows.Forms.RadioButton();
            this.gbTimeInterval = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnReport = new System.Windows.Forms.Button();
            this.dtpReport = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartAllReports)).BeginInit();
            this.gbTimeInterval.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAllReports
            // 
            this.chartAllReports.BackColor = System.Drawing.Color.LightCyan;
            chartArea1.Name = "ChartArea1";
            this.chartAllReports.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAllReports.Legends.Add(legend1);
            this.chartAllReports.Location = new System.Drawing.Point(28, 32);
            this.chartAllReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartAllReports.Name = "chartAllReports";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Siz";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Diğer Kullanıcılar";
            this.chartAllReports.Series.Add(series1);
            this.chartAllReports.Series.Add(series2);
            this.chartAllReports.Size = new System.Drawing.Size(471, 300);
            this.chartAllReports.TabIndex = 0;
            this.chartAllReports.Text = "chart1";
            // 
            // rbtnWeekly
            // 
            this.rbtnWeekly.AutoSize = true;
            this.rbtnWeekly.Checked = true;
            this.rbtnWeekly.Location = new System.Drawing.Point(19, 18);
            this.rbtnWeekly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnWeekly.Name = "rbtnWeekly";
            this.rbtnWeekly.Size = new System.Drawing.Size(76, 21);
            this.rbtnWeekly.TabIndex = 1;
            this.rbtnWeekly.TabStop = true;
            this.rbtnWeekly.Text = "Haftalık";
            this.rbtnWeekly.UseVisualStyleBackColor = true;
            // 
            // rbtnMonthly
            // 
            this.rbtnMonthly.AutoSize = true;
            this.rbtnMonthly.Location = new System.Drawing.Point(144, 18);
            this.rbtnMonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMonthly.Name = "rbtnMonthly";
            this.rbtnMonthly.Size = new System.Drawing.Size(58, 21);
            this.rbtnMonthly.TabIndex = 2;
            this.rbtnMonthly.Text = "Aylık";
            this.rbtnMonthly.UseVisualStyleBackColor = true;
            // 
            // rbtnByMeal
            // 
            this.rbtnByMeal.AutoSize = true;
            this.rbtnByMeal.Checked = true;
            this.rbtnByMeal.Location = new System.Drawing.Point(19, 18);
            this.rbtnByMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnByMeal.Name = "rbtnByMeal";
            this.rbtnByMeal.Size = new System.Drawing.Size(105, 21);
            this.rbtnByMeal.TabIndex = 3;
            this.rbtnByMeal.TabStop = true;
            this.rbtnByMeal.Text = "Öğüne göre";
            this.rbtnByMeal.UseVisualStyleBackColor = true;
            // 
            // rbtnByCategory
            // 
            this.rbtnByCategory.AutoSize = true;
            this.rbtnByCategory.Location = new System.Drawing.Point(144, 18);
            this.rbtnByCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnByCategory.Name = "rbtnByCategory";
            this.rbtnByCategory.Size = new System.Drawing.Size(130, 21);
            this.rbtnByCategory.TabIndex = 4;
            this.rbtnByCategory.Text = "Kategoriye göre";
            this.rbtnByCategory.UseVisualStyleBackColor = true;
            // 
            // gbTimeInterval
            // 
            this.gbTimeInterval.Controls.Add(this.rbtnMonthly);
            this.gbTimeInterval.Controls.Add(this.rbtnWeekly);
            this.gbTimeInterval.Location = new System.Drawing.Point(131, 343);
            this.gbTimeInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimeInterval.Name = "gbTimeInterval";
            this.gbTimeInterval.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimeInterval.Size = new System.Drawing.Size(285, 46);
            this.gbTimeInterval.TabIndex = 5;
            this.gbTimeInterval.TabStop = false;
            this.gbTimeInterval.Text = "Zaman Aralığı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnByMeal);
            this.groupBox2.Controls.Add(this.rbtnByCategory);
            this.groupBox2.Location = new System.Drawing.Point(131, 395);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(285, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğün/Kategori";
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnReport.Location = new System.Drawing.Point(224, 495);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(95, 31);
            this.BtnReport.TabIndex = 7;
            this.BtnReport.Text = "Raporla";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // dtpReport
            // 
            this.dtpReport.Location = new System.Drawing.Point(149, 464);
            this.dtpReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(265, 22);
            this.dtpReport.TabIndex = 8;
            // 
            // ComparisonReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(545, 539);
            this.Controls.Add(this.dtpReport);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbTimeInterval);
            this.Controls.Add(this.chartAllReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ComparisonReports";
            this.Text = "ComparisonReports";
            this.Load += new System.EventHandler(this.ComparisonReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAllReports)).EndInit();
            this.gbTimeInterval.ResumeLayout(false);
            this.gbTimeInterval.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAllReports;
        private System.Windows.Forms.RadioButton rbtnWeekly;
        private System.Windows.Forms.RadioButton rbtnMonthly;
        private System.Windows.Forms.RadioButton rbtnByMeal;
        private System.Windows.Forms.RadioButton rbtnByCategory;
        private System.Windows.Forms.GroupBox gbTimeInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.DateTimePicker dtpReport;
    }
}