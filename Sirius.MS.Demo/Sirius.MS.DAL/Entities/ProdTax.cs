using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class ProdTax
    {
        public long Id { get; set; }
        public long? ProdId { get; set; }
        public long? TaxId { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual Product Prod { get; set; }
        public virtual Tax Tax { get; set; }
    }
}
