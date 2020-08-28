namespace Банк_Тест
{
    partial class AddOrganization
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCorp = new System.Windows.Forms.TextBox();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование организации";
            // 
            // txtNameCorp
            // 
            this.txtNameCorp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameCorp.Location = new System.Drawing.Point(25, 103);
            this.txtNameCorp.Name = "txtNameCorp";
            this.txtNameCorp.Size = new System.Drawing.Size(514, 32);
            this.txtNameCorp.TabIndex = 8;
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrganization.Location = new System.Drawing.Point(163, 153);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(239, 48);
            this.btnAddOrganization.TabIndex = 7;
            this.btnAddOrganization.Text = "Добавить";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // AddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameCorp);
            this.Controls.Add(this.btnAddOrganization);
            this.Name = "AddOrganization";
            this.Text = "Добавить организацию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameCorp;
        private System.Windows.Forms.Button btnAddOrganization;
    }
}