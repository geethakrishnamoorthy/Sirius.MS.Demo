using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class SaleDtl
    {
        public long Id { get; set; }
        public long? SaleMstId { get; set; }
        public long? ProdId { get; set; }
        public long? PriceId { get; set; }
        public decimal? Qty { get; set; }
        public long? GmidUnit { get; set; }
        public decimal? Amt { get; set; }
        public decimal? DiscountAmt { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? TotalAmt { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual GenMst GmidUnitNavigation { get; set; }
        public virtual Price Price { get; set; }
        public virtual Product Prod { get; set; }
        public virtual SaleMst SaleMst { get; set; }
    }
}
