//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practicMVVM.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Готовое_ТЦ
    {
        public string ID { get; set; }
        public string Название { get; set; }
        public int Кол__Повильонов { get; set; }
        public string Город { get; set; }
        public decimal Стоимость { get; set; }
        public double Кооф__Добавочной_Стоимости { get; set; }
        public int Этажность { get; set; }
        public int Статус_ТЦ { get; set; }
        public byte[] Фото { get; set; }
    }
}
