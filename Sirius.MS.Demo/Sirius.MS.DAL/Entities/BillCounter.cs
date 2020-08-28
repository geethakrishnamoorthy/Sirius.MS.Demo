using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class BillCounter
    {
        public BillCounter()
        {
            SaleMst = new HashSet<SaleMst>();
        }

        public long Id { get; set; }
        public string BillCtrCode { get; set; }
        public string BillCtrName { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual ICollection<SaleMst> SaleMst { get; set; }
    }
}
