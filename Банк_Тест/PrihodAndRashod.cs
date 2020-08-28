using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Банк_Тест
{
    public class PrihodAndRashod // Класс с полями для определения xml
    {
        public int Id_prihod { get; set; }
        public int Id_Number_line { get; set; }
        public string Наименование_товара { get; set; }
        public int Количество_товара { get; set; }
        public decimal Стоимость_за_единицу { get; set; }
        public decimal Сумма_стоимости { get; set; }

        public DateTime Дата_поступления { get; set; }
        public string Наименование_склада { get; set; }
        public string Наименование_организации { get; set; }
    }
}
