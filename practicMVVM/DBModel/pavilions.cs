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
    
    public partial class pavilions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pavilions()
        {
            this.rental = new HashSet<rental>();
        }
    
        public string IdPavilions { get; set; }
        public string IdSM { get; set; }
        public Nullable<int> floor { get; set; }
        public decimal square { get; set; }
        public decimal costMeter { get; set; }
        public Nullable<decimal> coefficientAddedValue { get; set; }
        public int IdPavilionsStatus { get; set; }
    
        public virtual statusPavilions statusPavilions { get; set; }
        public virtual shoppingMalls shoppingMalls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rental> rental { get; set; }
    }
}
