using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Discount
    {
        public Discount()
        {
            ProdDiscount = new HashSet<ProdDiscount>();
        }

        public long Id { get; set; }
        public string DisType { get; set; }
        public string DisName { get; set; }
        public string DisPercent { get; set; }
        public string DisGift { get; set; }
        public DateTime? DisStart { get; set; }
        public DateTime? DisEnd { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual ICollection<ProdDiscount> ProdDiscount { get; set; }
    }
}
