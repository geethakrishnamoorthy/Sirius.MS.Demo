using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Price
    {
        public Price()
        {
            SaleDtl = new HashSet<SaleDtl>();
            SaleReturnDtl = new HashSet<SaleReturnDtl>();
        }

        public long Id { get; set; }
        public long? ProdId { get; set; }
        public decimal? Mrprate { get; set; }
        public decimal? SaleRate { get; set; }
        public long? GmidUnit { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual GenMst GmidUnitNavigation { get; set; }
        public virtual Product Prod { get; set; }
        public virtual ICollection<SaleDtl> SaleDtl { get; set; }
        public virtual ICollection<SaleReturnDtl> SaleReturnDtl { get; set; }
    }
}
