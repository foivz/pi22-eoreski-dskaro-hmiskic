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
    
    public partial class stavka_narudzbe
    {
        public int id_stavka_narudzbe { get; set; }
        public int id_narudzbenica { get; set; }
        public int id_lijek { get; set; }
        public int narucena_kolicina { get; set; }
    
        public virtual lijek lijek { get; set; }
        public virtual narudzbenica narudzbenica { get; set; }
    }
}