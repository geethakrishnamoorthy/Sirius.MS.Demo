using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class PurReturnMst
    {
        public PurReturnMst()
        {
            PurReturnDtl = new HashSet<PurReturnDtl>();
        }

        public long Id { get; set; }
        public string PurReturnNo { get; set; }
        public DateTime? PurReturnDate { get; set; }
        public long? PurRptMstId { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual PurRptMst PurRptMst { get; set; }
        public virtual ICollection<PurReturnDtl> PurReturnDtl { get; set; }
    }
}
