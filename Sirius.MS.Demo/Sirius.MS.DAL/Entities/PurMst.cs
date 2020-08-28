using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class PurMst
    {
        public PurMst()
        {
            PurDtl = new HashSet<PurDtl>();
            PurPayment = new HashSet<PurPayment>();
            PurRptMst = new HashSet<PurRptMst>();
        }

        public long Id { get; set; }
        public DateTime? PurDate { get; set; }
        public string PurOdrNo { get; set; }
        public long? SupId { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual Supplier Sup { get; set; }
        public virtual ICollection<PurDtl> PurDtl { get; set; }
        public virtual ICollection<PurPayment> PurPayment { get; set; }
        public virtual ICollection<PurRptMst> PurRptMst { get; set; }
    }
}
