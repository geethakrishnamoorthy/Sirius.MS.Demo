using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class ProdSupplier
    {
        public long Id { get; set; }
        public long? SupplierId { get; set; }
        public long? ProdId { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual Product Prod { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
