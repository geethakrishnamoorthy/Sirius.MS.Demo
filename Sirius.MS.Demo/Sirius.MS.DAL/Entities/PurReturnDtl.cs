using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class PurReturnDtl
    {
        public long Id { get; set; }
        public long? PurReturnMstId { get; set; }
        public long? ProdId { get; set; }
        public int? Qty { get; set; }
        public long? GmidUnit { get; set; }
        public long? GmidReturnType { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual GenMst GmidReturnTypeNavigation { get; set; }
        public virtual GenMst GmidUnitNavigation { get; set; }
        public virtual Product Prod { get; set; }
        public virtual PurReturnMst PurReturnMst { get; set; }
    }
}
