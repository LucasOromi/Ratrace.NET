//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custom.Social
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exchange
    {
        public int Id { get; set; }
        public System.DateTime SentOn { get; set; }
        public System.DateTime SeenOn { get; set; }
    
        public virtual Message Message { get; set; }
        public virtual Contact Recipient { get; set; }
        public virtual Contact Sender { get; set; }
    }
}