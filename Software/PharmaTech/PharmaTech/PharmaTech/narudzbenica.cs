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
    
    public partial class narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public narudzbenica()
        {
            this.skladisna_primka = new HashSet<skladisna_primka>();
            this.stavka_narudzbe = new HashSet<stavka_narudzbe>();
        }
    
        public int id_narudzbenica { get; set; }
        public System.DateTime datum_narudzbe { get; set; }
        public int id_dobavljac { get; set; }
        public int id_zaposlenik { get; set; }
        public string status { get; set; }
    
        public virtual dobavljac dobavljac { get; set; }
        public virtual zaposlenik zaposlenik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skladisna_primka> skladisna_primka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavka_narudzbe> stavka_narudzbe { get; set; }
    }
}
