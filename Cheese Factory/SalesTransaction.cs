//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cheese_Factory
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesTransaction
    {
        public string SalesTransactionID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<System.DateTime> SalesTransactionDate { get; set; }
        public string PaymentType { get; set; }
        public string ShippingLocation { get; set; }
        public string Transportation { get; set; }
        public Nullable<System.DateTime> ShippingTime { get; set; }
        public Nullable<int> NumberOfBatch { get; set; }
        public string SalesTransactionStatus { get; set; }
        public string InsertBy { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string ConfirmBy { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public Nullable<int> TransportPrice { get; set; }
    }
}
