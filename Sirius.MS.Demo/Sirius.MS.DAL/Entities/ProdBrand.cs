using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class ProdBrand
    {
        public long Id { get; set; }
        public string BrandCode { get; set; }
        public string BrandSname { get; set; }
        public string BrandLname { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }
    }
}
