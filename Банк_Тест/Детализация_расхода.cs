//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Банк_Тест
{
    using System;
    using System.Collections.Generic;
    
    public partial class Детализация_расхода
    {
        public int Id_rashod { get; set; }
        public int Id_Number_line { get; set; }
        public string Наименование_товара { get; set; }
        public int Количество { get; set; }
        public decimal Стоимость_за_единицу { get; set; }
        public decimal Сумма_стоимости { get; set; }
    
        public virtual Расход Расход { get; set; }
        public virtual Товар Товар { get; set; }
    }
}
