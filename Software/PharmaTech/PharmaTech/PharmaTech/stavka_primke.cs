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
    
    public partial class stavka_primke
    {
        public int id_stavka_primke { get; set; }
        public int id_primka { get; set; }
        public int id_lijek { get; set; }
        public int primljena_kolicina { get; set; }
    
        public virtual lijek lijek { get; set; }
    }
}
