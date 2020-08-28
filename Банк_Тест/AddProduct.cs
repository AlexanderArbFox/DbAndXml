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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            ClearedTxt();
        }

        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                try
                {
                    if (txtNameProduct.Text.Equals(""))
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    else
                    {
                        Товар tov = new Товар()
                        {
                            Наименование_товара = txtNameProduct.Text,
                        };
                        db.Товар.Add(tov);
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
                    txtNameProduct.Text = "";
                }
            }
        }

