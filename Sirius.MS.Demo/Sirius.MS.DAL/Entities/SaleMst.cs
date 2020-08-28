using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class SaleMst
    {
        public SaleMst()
        {
            SaleDtl = new HashSet<SaleDtl>();
            SalePayment = new HashSet<SalePayment>();
            SaleReturnMst = new HashSet<SaleReturnMst>();
        }

        public long Id { get; set; }
        public DateTime? SaleDate { get; set; }
        public string SaleNo { get; set; }
        public long? CustId { get; set; }
        public string Mobile { get; set; }
        public decimal? SaleAmt { get; set; }
        public decimal? DiscountAmt { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? TotalAmt { get; set; }
        public string Remarks { get; set; }
        public long? UserId { get; set; }
        public long? BillCtrId { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual BillCounter BillCtr { get; set; }
        public virtual Customer Cust { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<SaleDtl> SaleDtl { get; set; }
        public virtual ICollection<SalePayment> SalePayment { get; set; }
        public virtual ICollection<SaleReturnMst> SaleReturnMst { get; set; }
    }
}
