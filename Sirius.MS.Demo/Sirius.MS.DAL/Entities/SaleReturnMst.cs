using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class SaleReturnMst
    {
        public SaleReturnMst()
        {
            SaleReturnDtl = new HashSet<SaleReturnDtl>();
        }

        public long Id { get; set; }
        public DateTime? SaleReturnDate { get; set; }
        public long? SaleMstId { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual SaleMst SaleMst { get; set; }
        public virtual ICollection<SaleReturnDtl> SaleReturnDtl { get; set; }
    }
}
