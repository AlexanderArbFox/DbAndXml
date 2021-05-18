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
using Excel1 = Microsoft.Office.Interop.Excel;

namespace Банк_Тест
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            cmbSelect.SelectedIndex = 0; // по инициализациии приложения берется нулевой элемент в комбобокс
        }
        public dynamic ExetQueryPrihod(Context db) // поля для прихода в бд
        {
            return db.Детализация_прихода.Select(s => new
            {
                s.Приход.Дата_поступления,
                s.Приход.Наименование_склада,
                s.Приход.Наименование_организации,
                s.Наименование_товара,
                s.Количество_товара,
                s.Сумма_стоимости
            }).ToList();
        }

        public dynamic ExetQueryRashod(Context db) //поля для расхода в бд
        {
            return db.Детализация_расхода.Select(s => new
            {
                s.Расход.Дата_расхода,
                s.Расход.Наименование_склада,
                s.Расход.Наименование_организации,
                s.Наименование_товара,
                s.Количество,
                s.Сумма_стоимости
            }).ToList();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e) // подгрузка полей в таблице по выбору
        {
            using (Context db = new Context())
            {
                switch (cmbSelect.SelectedIndex)
                {
                    case 0:
                        dgvReport.DataSource = ExetQueryPrihod(db);
                        break;
                    case 1:
                        dgvReport.DataSource = ExetQueryRashod(db);
                        break;
                }
                SumTovars();
            }

        }
        private void SumTovars() // подсчет суммы в столбце стоимость
        {
          int sum = 0;
            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvReport.Rows[i].Cells[5].Value);
            }
            lbSum.Text = "Сумма товаров составляет: " + sum.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e) // поиск по дате в таблице
        {
            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dgvReport.Rows[i].Cells[0].Value) >= dtpOt.Value && Convert.ToDateTime(dgvReport.Rows[i].Cells[0].Value) <= dtpDo.Value)
                {
                    dgvReport.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
    }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //Выгрузка в excel
            var b = DateTime.Now;
            string path = Directory.GetCurrentDirectory() + @"\" + "Отчет.xlsx";
            Excel1.Application excelapp = new Excel1.Application();
            Excel1.Workbook workbook = excelapp.Workbooks.Add();
            Excel1.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dgvReport.RowCount + 1; i++)
            {
                for (int j = 1; j < dgvReport.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dgvReport.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            worksheet.SaveAs(path);
            excelapp.Quit();

            MessageBox.Show("Данные успешно сохранены в Excel");
        
        }
    }
}
