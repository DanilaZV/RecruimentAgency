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
    
    public partial class NaimenovanieVacanciy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaimenovanieVacanciy()
        {
            this.Vacansies = new HashSet<Vacansies>();
        }
    
        public int id { get; set; }
        public string NaimenovanieVacancii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacansies> Vacansies { get; set; }
    }
}
