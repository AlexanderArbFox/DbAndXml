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
    public partial class AddOrganization : Form
    {
        public AddOrganization()
        {
            InitializeComponent();
            ClearedTxt();
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                try
                {
                    if (txtNameCorp.Text.Equals(""))
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    else
                    {
                        Организации org = new Организации()
                        {
                            Название_компании = txtNameCorp.Text,
                        };
                        db.Организации.Add(org);
                        db.SaveChanges();
                        MessageBox.Show("Успешно добавлено");
                        ClearedTxt();
                    }

                }
                catch
                {

                }
            }
        }
        private void ClearedTxt()
        {
            txtNameCorp.Text = "";

        }
    }
}
