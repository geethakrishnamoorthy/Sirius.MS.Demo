using System;

namespace Sirius.MS.BAL.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string ProdCode { get; set; }
        public string ProdSname { get; set; }
        public string ProdLname { get; set; }
        public long? GmidUnit { get; set; }
        public long? MinQty { get; set; }
        public long? ReorderQty { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }
        public GenMstModel GmidUnitNavigation { get; set; }
        public long GenMstId { get; set; }

    }
}
