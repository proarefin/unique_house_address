//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_Adressverwaltung
{
    using System;
    using System.Collections.Generic;
    
    public partial class Anschrift
    {
        public int AnschriftID { get; set; }
        public string StraßeName { get; set; }
        public string WohnungNummer { get; set; }
        public string PLZ { get; set; }
        public Nullable<int> StadtId { get; set; }
        public int LandId { get; set; }
        public byte[] HashValue { get; set; }
        public string HashCode { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Stadt Stadt { get; set; }
    }
}