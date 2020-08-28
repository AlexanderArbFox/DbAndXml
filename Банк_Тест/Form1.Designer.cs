namespace Банк_Тест
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrihod = new System.Windows.Forms.Button();
            this.btnSklad = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrihod
            // 
            this.btnPrihod.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrihod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrihod.Location = new System.Drawing.Point(61, 47);
            this.btnPrihod.Name = "btnPrihod";
            this.btnPrihod.Size = new System.Drawing.Size(223, 72);
            this.btnPrihod.TabIndex = 0;
            this.btnPrihod.Text = "Приход";
            this.btnPrihod.UseVisualStyleBackColor = false;
            this.btnPrihod.Click += new System.EventHandler(this.btnPrihod_Click);
            // 
            // btnSklad
            // 
            this.btnSklad.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSklad.Location = new System.Drawing.Point(61, 144);
            this.btnSklad.Name = "btnSklad";
            this.btnSklad.Size = new System.Drawing.Size(223, 72);
            this.btnSklad.TabIndex = 2;
            this.btnSklad.Text = "Склад";
            this.btnSklad.UseVisualStyleBackColor = false;
            this.btnSklad.Click += new System.EventHandler(this.btnSklad_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(61, 239);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(223, 72);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 367);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSklad);
            this.Controls.Add(this.btnPrihod);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrihod;
        private System.Windows.Forms.Button btnSklad;
        private System.Windows.Forms.Button btnReport;
    }
}

