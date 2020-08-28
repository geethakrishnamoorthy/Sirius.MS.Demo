using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Product
    {
        public Product()
        {
            Price = new HashSet<Price>();
            ProdDiscount = new HashSet<ProdDiscount>();
            ProdSupplier = new HashSet<ProdSupplier>();
            ProdTax = new HashSet<ProdTax>();
            PurDtl = new HashSet<PurDtl>();
            PurReturnDtl = new HashSet<PurReturnDtl>();
            PurRptDtl = new HashSet<PurRptDtl>();
            SaleDtl = new HashSet<SaleDtl>();
            SaleReturnDtl = new HashSet<SaleReturnDtl>();
            Stock = new HashSet<Stock>();
            StockTxn = new HashSet<StockTxn>();
        }

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

        public virtual GenMst GmidUnitNavigation { get; set; }
        public virtual ICollection<Price> Price { get; set; }
        public virtual ICollection<ProdDiscount> ProdDiscount { get; set; }
        public virtual ICollection<ProdSupplier> ProdSupplier { get; set; }
        public virtual ICollection<ProdTax> ProdTax { get; set; }
        public virtual ICollection<PurDtl> PurDtl { get; set; }
        public virtual ICollection<PurReturnDtl> PurReturnDtl { get; set; }
        public virtual ICollection<PurRptDtl> PurRptDtl { get; set; }
        public virtual ICollection<SaleDtl> SaleDtl { get; set; }
        public virtual ICollection<SaleReturnDtl> SaleReturnDtl { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTxn> StockTxn { get; set; }
    }
}
