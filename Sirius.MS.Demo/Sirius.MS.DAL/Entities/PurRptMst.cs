using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class PurRptMst
    {
        public PurRptMst()
        {
            PurReturnMst = new HashSet<PurReturnMst>();
            PurRptDtl = new HashSet<PurRptDtl>();
            Stock = new HashSet<Stock>();
        }

        public long Id { get; set; }
        public DateTime? PurRptDate { get; set; }
        public string PurRptNo { get; set; }
        public long? PurOdrId { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual PurMst PurOdr { get; set; }
        public virtual ICollection<PurReturnMst> PurReturnMst { get; set; }
        public virtual ICollection<PurRptDtl> PurRptDtl { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
