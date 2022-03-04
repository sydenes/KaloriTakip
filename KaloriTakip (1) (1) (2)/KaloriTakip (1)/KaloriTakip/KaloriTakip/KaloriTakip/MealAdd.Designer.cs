
namespace KaloriTakip
{
    partial class MealAdd
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.lstvFoods = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudSerValue = new System.Windows.Forms.NumericUpDown();
            this.pboxFoodImage = new System.Windows.Forms.PictureBox();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblCarbonh = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstvAddedFoods = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.AccessibleDescription = "";
            this.cmbCategories.AccessibleName = "";
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(70, 69);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(191, 24);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(279, 69);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(246, 22);
            this.txtSearchFood.TabIndex = 1;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // lstvFoods
            // 
            this.lstvFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstvFoods.GridLines = true;
            this.lstvFoods.HideSelection = false;
            this.lstvFoods.Location = new System.Drawing.Point(70, 144);
            this.lstvFoods.Name = "lstvFoods";
            this.lstvFoods.Size = new System.Drawing.Size(191, 314);
            this.lstvFoods.TabIndex = 2;
            this.lstvFoods.UseCompatibleStateImageBehavior = false;
            this.lstvFoods.View = System.Windows.Forms.View.Details;
            this.lstvFoods.Click += new System.EventHandler(this.lstvFoods_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCarbonh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCalorie);
            this.groupBox1.Controls.Add(this.pboxFoodImage);
            this.groupBox1.Controls.Add(this.nudSerValue);
            this.groupBox1.Location = new System.Drawing.Point(279, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nudSerValue
            // 
            this.nudSerValue.Location = new System.Drawing.Point(6, 98);
            this.nudSerValue.Name = "nudSerValue";
            this.nudSerValue.Size = new System.Drawing.Size(107, 22);
            this.nudSerValue.TabIndex = 0;
            // 
            // pboxFoodImage
            // 
            this.pboxFoodImage.Location = new System.Drawing.Point(6, 21);
            this.pboxFoodImage.Name = "pboxFoodImage";
            this.pboxFoodImage.Size = new System.Drawing.Size(107, 59);
            this.pboxFoodImage.TabIndex = 1;
            this.pboxFoodImage.TabStop = false;
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(276, 21);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(46, 17);
            this.lblCalorie.TabIndex = 2;
            this.lblCalorie.Text = "label1";
            // 
            // lblCarbonh
            // 
            this.lblCarbonh.AutoSize = true;
            this.lblCarbonh.Location = new System.Drawing.Point(276, 63);
            this.lblCarbonh.Name = "lblCarbonh";
            this.lblCarbonh.Size = new System.Drawing.Size(46, 17);
            this.lblCarbonh.TabIndex = 2;
            this.lblCarbonh.Text = "label1";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(276, 98);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(46, 17);
            this.lblPro.TabIndex = 2;
            this.lblPro.Text = "label1";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(276, 132);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(46, 17);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstvAddedFoods
            // 
            this.lstvAddedFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lstvAddedFoods.FullRowSelect = true;
            this.lstvAddedFoods.GridLines = true;
            this.lstvAddedFoods.HideSelection = false;
            this.lstvAddedFoods.Location = new System.Drawing.Point(267, 319);
            this.lstvAddedFoods.Name = "lstvAddedFoods";
            this.lstvAddedFoods.Size = new System.Drawing.Size(274, 139);
            this.lstvAddedFoods.TabIndex = 4;
            this.lstvAddedFoods.UseCompatibleStateImageBehavior = false;
            this.lstvAddedFoods.View = System.Windows.Forms.View.Details;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(547, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(547, 424);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 34);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Onay";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kalori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Karbonhidrat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Protein:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yağ:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Foods";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Besin Adı:";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 86;
            // 
            // MealAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 476);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstvAddedFoods);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstvFoods);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.cmbCategories);
            this.Name = "MealAdd";
            this.Text = "MealAdd";
            this.Load += new System.EventHandler(this.MealAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.ListView lstvFoods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lblCarbonh;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.PictureBox pboxFoodImage;
        private System.Windows.Forms.NumericUpDown nudSerValue;
        private System.Windows.Forms.ListView lstvAddedFoods;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}