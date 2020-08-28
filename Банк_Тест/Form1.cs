using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Банк_Тест
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrihod_Click(object sender, EventArgs e)
        {
            Prihod fae = new Prihod();
            if (fae.ShowDialog(this) == DialogResult.OK)
            {
              //  btnAddTovar.Text = fae.txtNameTov.Text;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Show();
        }

        private void btnSklad_Click(object sender, EventArgs e)
        {
            Sklad sklad = new Sklad();
            sklad.Show();
        }
    }
}
