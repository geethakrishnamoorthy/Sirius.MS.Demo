using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Tax
    {
        public Tax()
        {
            ProdTax = new HashSet<ProdTax>();
        }

        public long Id { get; set; }
        public long? GmidType { get; set; }
        public string TaxName { get; set; }
        public string TaxValue { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual GenMst GmidTypeNavigation { get; set; }
        public virtual ICollection<ProdTax> ProdTax { get; set; }
    }
}
