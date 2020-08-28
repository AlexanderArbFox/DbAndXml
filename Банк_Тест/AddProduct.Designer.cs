namespace Банк_Тест
{
    partial class AddProduct
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
            this.btnAddTovar = new System.Windows.Forms.Button();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTovar
            // 
            this.btnAddTovar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTovar.Location = new System.Drawing.Point(148, 181);
            this.btnAddTovar.Name = "btnAddTovar";
            this.btnAddTovar.Size = new System.Drawing.Size(239, 48);
            this.btnAddTovar.TabIndex = 4;
            this.btnAddTovar.Text = "Добавить";
            this.btnAddTovar.UseVisualStyleBackColor = false;
            this.btnAddTovar.Click += new System.EventHandler(this.btnAddTovar_Click);
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameProduct.Location = new System.Drawing.Point(10, 131);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(514, 32);
            this.txtNameProduct.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Наименование продукта";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.btnAddTovar);
            this.Name = "AddProduct";
            this.Text = "Добавить продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTovar;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label1;
    }
}