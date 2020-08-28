namespace Банк_Тест
{
    partial class Prihod
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
            this.components = new System.ComponentModel.Container();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.btnAddPrihod = new System.Windows.Forms.Button();
            this.cmbNameSklad = new System.Windows.Forms.ComboBox();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNameOrganization = new System.Windows.Forms.ComboBox();
            this.организацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNameTovar = new System.Windows.Forms.ComboBox();
            this.UpDownKolvo = new System.Windows.Forms.NumericUpDown();
            this.UpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.lbSumma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownKolvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.Location = new System.Drawing.Point(371, 430);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(296, 58);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Добавить продукт";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrganization.Location = new System.Drawing.Point(12, 430);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(315, 58);
            this.btnAddOrganization.TabIndex = 2;
            this.btnAddOrganization.Text = "Добавить организацию";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // btnAddPrihod
            // 
            this.btnAddPrihod.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPrihod.Location = new System.Drawing.Point(281, 337);
            this.btnAddPrihod.Name = "btnAddPrihod";
            this.btnAddPrihod.Size = new System.Drawing.Size(239, 56);
            this.btnAddPrihod.TabIndex = 3;
            this.btnAddPrihod.Text = "Добавить";
            this.btnAddPrihod.UseVisualStyleBackColor = false;
            this.btnAddPrihod.Click += new System.EventHandler(this.btnAddPrihod_Click);
            // 
            // cmbNameSklad
            // 
            this.cmbNameSklad.DataSource = this.складBindingSource;
            this.cmbNameSklad.DisplayMember = "Наименование_склада";
            this.cmbNameSklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNameSklad.FormattingEnabled = true;
            this.cmbNameSklad.Location = new System.Drawing.Point(281, 35);
            this.cmbNameSklad.Name = "cmbNameSklad";
            this.cmbNameSklad.Size = new System.Drawing.Size(239, 34);
            this.cmbNameSklad.TabIndex = 4;
            this.cmbNameSklad.ValueMember = "Наименование_склада";
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataSource = typeof(Банк_Тест.Склад);
            // 
            // cmbNameOrganization
            // 
            this.cmbNameOrganization.DataSource = this.организацииBindingSource;
            this.cmbNameOrganization.DisplayMember = "Название_компании";
            this.cmbNameOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNameOrganization.FormattingEnabled = true;
            this.cmbNameOrganization.Location = new System.Drawing.Point(281, 83);
            this.cmbNameOrganization.Name = "cmbNameOrganization";
            this.cmbNameOrganization.Size = new System.Drawing.Size(239, 34);
            this.cmbNameOrganization.TabIndex = 5;
            this.cmbNameOrganization.ValueMember = "Название_компании";
            // 
            // организацииBindingSource
            // 
            this.организацииBindingSource.DataSource = typeof(Банк_Тест.Организации);
            // 
            // cmbNameTovar
            // 
            this.cmbNameTovar.DataSource = this.товарBindingSource;
            this.cmbNameTovar.DisplayMember = "Наименование_товара";
            this.cmbNameTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNameTovar.FormattingEnabled = true;
            this.cmbNameTovar.Location = new System.Drawing.Point(281, 134);
            this.cmbNameTovar.Name = "cmbNameTovar";
            this.cmbNameTovar.Size = new System.Drawing.Size(239, 34);
            this.cmbNameTovar.TabIndex = 6;
            this.cmbNameTovar.ValueMember = "Наименование_товара";
            // 
            // UpDownKolvo
            // 
            this.UpDownKolvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownKolvo.Location = new System.Drawing.Point(344, 184);
            this.UpDownKolvo.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.UpDownKolvo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownKolvo.Name = "UpDownKolvo";
            this.UpDownKolvo.Size = new System.Drawing.Size(176, 32);
            this.UpDownKolvo.TabIndex = 7;
            this.UpDownKolvo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownKolvo.ValueChanged += new System.EventHandler(this.UpDownKolvo_ValueChanged);
            // 
            // UpDownPrice
            // 
            this.UpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownPrice.Location = new System.Drawing.Point(344, 224);
            this.UpDownPrice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.UpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownPrice.Name = "UpDownPrice";
            this.UpDownPrice.Size = new System.Drawing.Size(176, 32);
            this.UpDownPrice.TabIndex = 8;
            this.UpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownPrice.ValueChanged += new System.EventHandler(this.UpDownPrice_ValueChanged);
            // 
            // lbSumma
            // 
            this.lbSumma.AutoSize = true;
            this.lbSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumma.Location = new System.Drawing.Point(393, 274);
            this.lbSumma.Name = "lbSumma";
            this.lbSumma.Size = new System.Drawing.Size(24, 26);
            this.lbSumma.TabIndex = 9;
            this.lbSumma.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Склад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(116, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Организация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(147, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Товар";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(128, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(116, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Стоимость 1 ед";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(142, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сумма";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataSource = typeof(Банк_Тест.Товар);
            // 
            // Prihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSumma);
            this.Controls.Add(this.UpDownPrice);
            this.Controls.Add(this.UpDownKolvo);
            this.Controls.Add(this.cmbNameTovar);
            this.Controls.Add(this.cmbNameOrganization);
            this.Controls.Add(this.cmbNameSklad);
            this.Controls.Add(this.btnAddPrihod);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "Prihod";
            this.Text = "Приход";
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownKolvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPrihod;
        private System.Windows.Forms.ComboBox cmbNameSklad;
        private System.Windows.Forms.ComboBox cmbNameOrganization;
        private System.Windows.Forms.ComboBox cmbNameTovar;
        private System.Windows.Forms.NumericUpDown UpDownKolvo;
        private System.Windows.Forms.NumericUpDown UpDownPrice;
        private System.Windows.Forms.Label lbSumma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.BindingSource складBindingSource;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private System.Windows.Forms.BindingSource организацииBindingSource;
    }
}