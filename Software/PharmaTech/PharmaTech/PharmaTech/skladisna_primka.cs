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
    
    public partial class skladisna_primka
    {
        public int id_primka { get; set; }
        public System.DateTime datum_zaprimanja { get; set; }
        public int id_dobavljaca { get; set; }
        public int id_zaposlenik { get; set; }
        public int id_narudzbenice { get; set; }
    
        public virtual dobavljac dobavljac { get; set; }
        public virtual narudzbenica narudzbenica { get; set; }
        public virtual zaposlenik zaposlenik { get; set; }
    }
}
