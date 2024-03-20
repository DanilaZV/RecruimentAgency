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
    
    public partial class Applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Applicant()
        {
            this.Polzovateli = new HashSet<Polzovateli>();
            this.Vacansies = new HashSet<Vacansies>();
        }
    
        public int id { get; set; }
        public string FIO { get; set; }
        public int idGoroda { get; set; }
        public Nullable<System.DateTime> DataRojenia { get; set; }
        public int idPola { get; set; }
        public int idGrajdanstva { get; set; }
        public string OpitRabotu { get; set; }
        public int idMestaRabotu { get; set; }
        public string NachaloRabotu { get; set; }
        public string OkonchanieRabotu { get; set; }
        public int idDoljnosti { get; set; }
        public string Obyzonasti { get; set; }
        public string InformaciaOSebe { get; set; }
        public string KluchevieNaviki { get; set; }
        public int idSpecialnost { get; set; }
        public int idJelaimayaDoljnost { get; set; }
        public string Zarplata { get; set; }
    
        public virtual Doljnost Doljnost { get; set; }
        public virtual Doljnost Doljnost1 { get; set; }
        public virtual Goroda Goroda { get; set; }
        public virtual Grajdanstvo Grajdanstvo { get; set; }
        public virtual MestoRabotu MestoRabotu { get; set; }
        public virtual Pol Pol { get; set; }
        public virtual Specialnost Specialnost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Polzovateli> Polzovateli { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacansies> Vacansies { get; set; }
    }
}
