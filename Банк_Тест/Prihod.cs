using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Банк_Тест
{
    public partial class Prihod : Form
    {
        public Prihod()
        {
            InitializeComponent();
            using (Context db = new Context()) // добавляем из бд столбец в комбобокс
            {
                cmbNameSklad.DataSource = db.Склад.ToList();
                cmbNameOrganization.DataSource = db.Организации.ToList();
                cmbNameTovar.DataSource = db.Товар.ToList();

            }
        }

        #region открытие диалоговых окон для добавления продукта и организации
        private void btnAddProduct_Click(object sender, EventArgs e) 
        {
            AddProduct product = new AddProduct();
            if (product.ShowDialog(this) == DialogResult.OK)
            {
            }
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            AddOrganization organization = new AddOrganization();
            if (organization.ShowDialog(this) == DialogResult.OK)
            {
            }
        }
        #endregion

        private void btnAddPrihod_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {

                try
                {
                    Приход prihod = new Приход() //добавление в приход
                {
                    Дата_поступления = DateTime.Now,
                    Наименование_склада = cmbNameSklad.SelectedValue.ToString(),
                    Наименование_организации = cmbNameOrganization.SelectedValue.ToString()
                };
                Детализация_прихода dp = new Детализация_прихода() // добавление Детализация_прихода
                {
                    Id_prihod = prihod.Id_Postuplenie,
                    Наименование_товара = cmbNameTovar.SelectedValue.ToString(),
                    Количество_товара = (int)UpDownKolvo.Value,
                    Стоимость_за_единицу = (decimal)UpDownPrice.Value,
                    Сумма_стоимости = Convert.ToDecimal(lbSumma.Text)
                };
                db.Детализация_прихода.Add(dp);
                db.Приход.Add(prihod);
                db.SaveChanges();
                List<PrihodAndRashod> pr = new List<PrihodAndRashod>(); // создаем из элементов бд коллекцию
                XmlSerializer serializer = new XmlSerializer(typeof(List<PrihodAndRashod>)); // ыериализация xml файла
                pr.Add(new PrihodAndRashod()
                {
                    Id_prihod = prihod.Id_Postuplenie,
                    Id_Number_line = dp.Id_Number_line,
                    Наименование_товара = dp.Наименование_товара,
                    Количество_товара = dp.Количество_товара,
                    Стоимость_за_единицу = dp.Стоимость_за_единицу,
                    Сумма_стоимости = dp.Сумма_стоимости,
                    Дата_поступления = prihod.Дата_поступления,
                    Наименование_склада = prihod.Наименование_склада,
                    Наименование_организации = prihod.Наименование_организации
                }
                );
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Prihod.xml", FileMode.Create, FileAccess.Write)) // создаем xml файл
                {
                    serializer.Serialize(fs, pr);
                    MessageBox.Show("Успешно добавлено");
                }
            }
            catch
            {

            }
        }
        }

#region
        private void UpDownPrice_ValueChanged(object sender, EventArgs e)
        {
           lbSumma.Text = Convert.ToString(UpDownPrice.Value * UpDownKolvo.Value);
        }

        private void UpDownKolvo_ValueChanged(object sender, EventArgs e)
        {
            lbSumma.Text = Convert.ToString(UpDownPrice.Value * UpDownKolvo.Value);
        }
    #endregion

   

        
    }
}
