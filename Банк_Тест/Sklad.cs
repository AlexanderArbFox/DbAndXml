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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
            DbSclad();
        }

        dynamic ExetQuerySklad(Context db)// Выбор полей из таблицы
        {
            return db.Детализация_прихода.Select(s => new
            {
                s.Id_Number_line,
                s.Наименование_товара,
                s.Количество_товара,
                s.Стоимость_за_единицу,
                s.Сумма_стоимости,
                s.Приход.Наименование_склада,
                s.Приход.Наименование_организации

            }).ToList();
        }
        private void DbSclad() //загружаем поля в таблицу
        {
            using (Context db = new Context())
            {

                dgvSklad.DataSource = ExetQuerySklad(db);
            }
        }


        private void MenuSell_Click(object sender, EventArgs e) // по нажатию кнопки меню открывается диалоговое окно
        {
            DetailsRashod details = new DetailsRashod();
            details.ShowDialog();
        }

        private void dgvSklad_MouseDown(object sender, MouseEventArgs e) // по нажатию правой клавиши мыши определяется позиция на экране
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuRightMouse.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void dgvSklad_CellClick(object sender, DataGridViewCellEventArgs e) // поля которые будут прописаны на форме продажи с выводом информации
        {
            int row = dgvSklad.SelectedRows[0].Index;
            ClassCurrent.Id = (int)dgvSklad[0, row].Value;
            ClassCurrent.Tovar = (string)dgvSklad[1, row].Value;
            ClassCurrent.Kolvo = (int)dgvSklad[2, row].Value;
            ClassCurrent.Price = (decimal)dgvSklad[3, row].Value;
            ClassCurrent.Summa = (decimal)dgvSklad[4, row].Value;
            ClassCurrent.Sklad = (string)dgvSklad[5, row].Value;
            ClassCurrent.Organization = (string)dgvSklad[6, row].Value;
        }

        private void dgvSklad_CellClick(object sender, MouseEventArgs fdf) // берем нулевой индекс в таблице
        {
            int row = dgvSklad.SelectedRows[0].Index;

            DetailsRashod dr = new DetailsRashod();
            if (fdf.Button == MouseButtons.Right)
            {
                dr.ShowDialog();
            }
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите строку левой клавишей мыши, после чего нажмите правой для продажи");
        }
    }
}
