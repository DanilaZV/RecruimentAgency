//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecruimentAgencyAppIS4
{
    using System;
    using System.Collections.Generic;
    
    public partial class KompaniNaimenovanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KompaniNaimenovanie()
        {
            this.Kompanii = new HashSet<Kompanii>();
        }
    
        public int id { get; set; }
        public string NaimenovanieKompani { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kompanii> Kompanii { get; set; }
    }
}
