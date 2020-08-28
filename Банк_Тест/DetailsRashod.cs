using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Банк_Тест
{
    public partial class DetailsRashod : Form
    {
        public DetailsRashod()
        {
            InitializeComponent();
            UpDownKolvo.Maximum = ClassCurrent.Kolvo;
            using (Context db = new Context()) // Функция продажи
            {
                lbNameSklad.Text = ClassCurrent.Sklad;
                lbNameOrganization.Text = ClassCurrent.Organization;
                lbNameTovar.Text = ClassCurrent.Tovar;
                UpDownKolvo.Value = ClassCurrent.Kolvo;
                lbPrice.Text = Convert.ToString(ClassCurrent.Price);
                lbSumma.Text = Convert.ToString(ClassCurrent.Price * ClassCurrent.Kolvo); //подсчет суммы
                
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {

                try
                {
                    Расход rashod = new Расход()// добавляем проданный товар в расход
                    {
                        Дата_расхода = DateTime.Now,
                        Наименование_склада = lbNameSklad.Text,
                        Наименование_организации = lbNameOrganization.Text
                    };
                    Детализация_расхода dr = new Детализация_расхода() // добавляем проданный товар в детализацию расода
                    {
                        Id_rashod = rashod.Id_rashod,
                        Наименование_товара = lbNameTovar.Text,
                        Количество = (int)UpDownKolvo.Value,
                        Стоимость_за_единицу = Convert.ToDecimal(lbPrice.Text),
                        Сумма_стоимости = Convert.ToDecimal(lbSumma.Text)
                    };
                    db.Детализация_расхода.Add(dr);
                    db.Расход.Add(rashod);
                    Детализация_прихода dp_update = db.Детализация_прихода.Where(d => d.Id_Number_line == ClassCurrent.Id).FirstOrDefault();
                    dp_update.Количество_товара -= dr.Количество; // вычитаем количество со склада

                    if (dp_update.Количество_товара == 0) // проверка на наличие товара в приходе (на складе)
                    {
                        db.Детализация_прихода.Remove(dp_update);
                    }
                    db.SaveChanges();
                    List<PrihodAndRashod> pr = new List<PrihodAndRashod>();
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PrihodAndRashod>)); // операция с xml файлом
                    pr.Add(new PrihodAndRashod()
                    {
                        Id_prihod = rashod.Id_rashod,
                        Id_Number_line = dr.Id_Number_line,
                        Наименование_товара = dr.Наименование_товара,
                        Количество_товара = dr.Количество,
                        Стоимость_за_единицу = dr.Стоимость_за_единицу,
                        Сумма_стоимости = dr.Сумма_стоимости,
                        Дата_поступления = rashod.Дата_расхода,
                        Наименование_склада = rashod.Наименование_склада,
                        Наименование_организации = rashod.Наименование_организации
                    }
                    );
                    using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Rashod.xml", FileMode.Create, FileAccess.Write)) // создаем xml
                    {
                        serializer.Serialize(fs, pr);
                        MessageBox.Show("Успешно продано");
                    }
                }
                catch
                {

                }
            }
        }

        private void UpDownKolvo_ValueChanged(object sender, EventArgs e) //перемножение количества на стоимость за единицу
        {
            lbSumma.Text = Convert.ToString(UpDownKolvo.Value * ClassCurrent.Price);
        }
    }
}
