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
    
    public partial class Vacansies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vacansies()
        {
            this.Applicant = new HashSet<Applicant>();
        }
    
        public int id { get; set; }
        public int idKompanii { get; set; }
        public int idNaimenovaniaVacancia { get; set; }
        public int idDoljnosti { get; set; }
        public int idRegion { get; set; }
        public string ZarabotnaiPlata { get; set; }
        public string Uslovia { get; set; }
        public string Obazanosti { get; set; }
        public string Trebovania { get; set; }
    
        public virtual Doljnost Doljnost { get; set; }
        public virtual Kompanii Kompanii { get; set; }
        public virtual NaimenovanieVacanciy NaimenovanieVacanciy { get; set; }
        public virtual RegionNaimenovanie RegionNaimenovanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant> Applicant { get; set; }
    }
}
