namespace Банк_Тест
{
    partial class Sklad
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
            this.dgvSklad = new System.Windows.Forms.DataGridView();
            this.MenuRightMouse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSell = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).BeginInit();
            this.MenuRightMouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSklad
            // 
            this.dgvSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSklad.ContextMenuStrip = this.MenuRightMouse;
            this.dgvSklad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSklad.Location = new System.Drawing.Point(0, 0);
            this.dgvSklad.Name = "dgvSklad";
            this.dgvSklad.RowTemplate.Height = 28;
            this.dgvSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSklad.Size = new System.Drawing.Size(800, 450);
            this.dgvSklad.TabIndex = 0;
            this.dgvSklad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSklad_CellClick);
            this.dgvSklad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSklad_MouseDown);
            // 
            // MenuRightMouse
            // 
            this.MenuRightMouse.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuRightMouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSell});
            this.MenuRightMouse.Name = "MenuRightMouse";
            this.MenuRightMouse.Size = new System.Drawing.Size(155, 34);
            // 
            // MenuSell
            // 
            this.MenuSell.Name = "MenuSell";
            this.MenuSell.Size = new System.Drawing.Size(154, 30);
            this.MenuSell.Text = "Продать";
            this.MenuSell.Click += new System.EventHandler(this.MenuSell_Click);
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSklad);
            this.Name = "Sklad";
            this.Text = "Склад";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).EndInit();
            this.MenuRightMouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSklad;
        private System.Windows.Forms.ContextMenuStrip MenuRightMouse;
        private System.Windows.Forms.ToolStripMenuItem MenuSell;
    }
}