
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudSerValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Kahvaltı = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbarFat = new System.Windows.Forms.ProgressBar();
            this.pbarPro = new System.Windows.Forms.ProgressBar();
            this.pbarCalorie = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerValue)).BeginInit();
            this.Kahvaltı.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudSerValue
            // 
            this.nudSerValue.Location = new System.Drawing.Point(69, 475);
            this.nudSerValue.Name = "nudSerValue";
            this.nudSerValue.Size = new System.Drawing.Size(120, 22);
            this.nudSerValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "elma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kahvaltı
            // 
            this.Kahvaltı.Controls.Add(this.label4);
            this.Kahvaltı.Controls.Add(this.btnAdd);
            this.Kahvaltı.Location = new System.Drawing.Point(29, 229);
            this.Kahvaltı.Name = "Kahvaltı";
            this.Kahvaltı.Size = new System.Drawing.Size(378, 109);
            this.Kahvaltı.TabIndex = 9;
            this.Kahvaltı.TabStop = false;
            this.Kahvaltı.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(35, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "elma";
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
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 525);
            this.Controls.Add(this.pbarCalorie);
            this.Controls.Add(this.pbarPro);
            this.Controls.Add(this.pbarFat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kahvaltı);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nudSerValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.pbarCarbon);
            this.Controls.Add(this.dtpDate);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSerValue)).EndInit();
            this.Kahvaltı.ResumeLayout(false);
            this.Kahvaltı.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.ProgressBar pbarCarbon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudSerValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Kahvaltı;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbarFat;
        private System.Windows.Forms.ProgressBar pbarPro;
        private System.Windows.Forms.ProgressBar pbarCalorie;
    }
}