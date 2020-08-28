using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Stock
    {
        public Stock()
        {
            StockTxn = new HashSet<StockTxn>();
        }

        public long Id { get; set; }
        public DateTime? StockDate { get; set; }
        public long? PurRptMstId { get; set; }
        public long? ProdId { get; set; }
        public int? Qty { get; set; }
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
        public virtual PurRptMst PurRptMst { get; set; }
        public virtual ICollection<StockTxn> StockTxn { get; set; }
    }
}
