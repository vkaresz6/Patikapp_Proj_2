//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Patikapp_proj_2.Modells
{
    using System;
    using System.Collections.Generic;
    
    public partial class debtphtoph
    {
        public int id { get; set; }
        public int actor_id { get; set; }
        public int OEP_TTT { get; set; }
        public int from_ph_id { get; set; }
        public int to_ph_id { get; set; }
        public int amount { get; set; }
        public bool exists { get; set; }
        public System.DateTime ExpirationDay { get; set; }
    
        public virtual users users { get; set; }
        public virtual pharmacies pharmacies { get; set; }
        public virtual gyogysz gyogysz { get; set; }
        public virtual pharmacies pharmacies1 { get; set; }
    }
}