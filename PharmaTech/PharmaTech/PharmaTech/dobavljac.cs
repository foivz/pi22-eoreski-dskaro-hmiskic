//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmaTech
{
    using System;
    using System.Collections.Generic;
    
    public partial class dobavljac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dobavljac()
        {
            this.narudzbenicas = new HashSet<narudzbenica>();
            this.skladisna_primka = new HashSet<skladisna_primka>();
        }
    
        public int id_dobavljac { get; set; }
        public string naziv_dobavljaca { get; set; }
        public string kontakt { get; set; }
        public string racun_uplate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzbenica> narudzbenicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skladisna_primka> skladisna_primka { get; set; }
    }
}