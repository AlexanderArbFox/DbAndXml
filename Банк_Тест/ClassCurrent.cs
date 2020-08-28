using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Банк_Тест
{
    static class ClassCurrent // статический класс, для определения полей по продажи со склада
    {
        public static int Id { get; set; }
        public static string Sklad { get; set; }
        public static string Organization { get; set; }
        public static string Tovar { get; set; }
        public static int Kolvo{ get; set; }
        public static decimal Price { get; set; }
        public static decimal Summa { get; set; }

    }
}
