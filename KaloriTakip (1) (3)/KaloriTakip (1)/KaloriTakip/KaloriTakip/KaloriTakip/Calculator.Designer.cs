
namespace KaloriTakip
{
    partial class Calculator
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.pbarCarbon = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBreakfeast = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbarFat = new System.Windows.Forms.ProgressBar();
            this.pbarPro = new System.Windows.Forms.ProgressBar();
            this.pbarCalorie = new System.Windows.Forms.ProgressBar();
            this.pnlBreakfeast = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLunch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(144, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(206, 82);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(50, 17);
            this.lblCalorie.TabIndex = 2;
            this.lblCalorie.Text = "calorie";
            // 
            // pbarCarbon
            // 
            this.pbarCarbon.Location = new System.Drawing.Point(35, 196);
            this.pbarCarbon.Name = "pbarCarbon";
            this.pbarCarbon.Size = new System.Drawing.Size(82, 14);
            this.pbarCarbon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karbonhidrat";
            // 
            // btnBreakfeast
            // 
            this.btnBreakfeast.Location = new System.Drawing.Point(442, 41);
            this.btnBreakfeast.Name = "btnBreakfeast";
            this.btnBreakfeast.Size = new System.Drawing.Size(75, 23);
            this.btnBreakfeast.TabIndex = 8;
            this.btnBreakfeast.Tag = "1";
            this.btnBreakfeast.Text = "Ekle";
            this.btnBreakfeast.UseVisualStyleBackColor = true;
            this.btnBreakfeast.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbarFat
            // 
            this.pbarFat.Location = new System.Drawing.Point(315, 196);
            this.pbarFat.Name = "pbarFat";
            this.pbarFat.Size = new System.Drawing.Size(92, 14);
            this.pbarFat.TabIndex = 10;
            // 
            // pbarPro
            // 
            this.pbarPro.Location = new System.Drawing.Point(173, 196);
            this.pbarPro.Name = "pbarPro";
            this.pbarPro.Size = new System.Drawing.Size(92, 14);
            this.pbarPro.TabIndex = 10;
            // 
            // pbarCalorie
            // 
            this.pbarCalorie.Location = new System.Drawing.Point(173, 124);
            this.pbarCalorie.Name = "pbarCalorie";
            this.pbarCalorie.Size = new System.Drawing.Size(92, 14);
            this.pbarCalorie.TabIndex = 10;
            // 
            // pnlBreakfeast
            // 
            this.pnlBreakfeast.AutoScroll = true;
            this.pnlBreakfeast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBreakfeast.Location = new System.Drawing.Point(0, 437);
            this.pnlBreakfeast.Name = "pnlBreakfeast";
            this.pnlBreakfeast.Size = new System.Drawing.Size(529, 88);
            this.pnlBreakfeast.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnLunch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 100);
            this.panel1.TabIndex = 12;
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(442, 40);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(75, 23);
            this.btnLunch.TabIndex = 14;
            this.btnLunch.Tag = "2";
            this.btnLunch.Text = "Ekle";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBreakfeast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 100);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBreakfeast);
            this.Controls.Add(this.pbarCalorie);
            this.Controls.Add(this.pbarPro);
            this.Controls.Add(this.pbarFat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.pbarCarbon);
            this.Controls.Add(this.dtpDate);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.ProgressBar pbarCarbon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBreakfeast;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pbarFat;
        private System.Windows.Forms.ProgressBar pbarPro;
        private System.Windows.Forms.ProgressBar pbarCalorie;
        private System.Windows.Forms.Panel pnlBreakfeast;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Label label2;
    }
}