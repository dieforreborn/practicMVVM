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
    
    public partial class shoppingMalls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shoppingMalls()
        {
            this.pavilions = new HashSet<pavilions>();
        }
    
        public string IdSM { get; set; }
        public string nameSM { get; set; }
        public int numberPavilions { get; set; }
        public string city { get; set; }
        public decimal cost { get; set; }
        public Nullable<decimal> coefficientAddedValue { get; set; }
        public int numberFloors { get; set; }
        public int IdSMStatus { get; set; }
        public byte[] photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pavilions> pavilions { get; set; }
        public virtual statusSM statusSM { get; set; }
    }
}
