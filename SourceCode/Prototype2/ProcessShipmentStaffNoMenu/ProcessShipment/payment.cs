//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessShipment
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        public int paymentID { get; set; }
        public float paymentAmount { get; set; }
        public System.DateTime paymentDueDate { get; set; }
        public sbyte paymentStatus { get; set; }
        public sbyte paymentMethod { get; set; }
        public int payment_cusID { get; set; }
        public int airwaybill_airwayBillId { get; set; }
    
        public virtual airwaybill airwaybill { get; set; }
        public virtual customer customer { get; set; }
    }
}
