using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class ProdGroup
    {
        public long Id { get; set; }
        public string GroupCode { get; set; }
        public string GroupSname { get; set; }
        public string GroupLname { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }
    }
}
