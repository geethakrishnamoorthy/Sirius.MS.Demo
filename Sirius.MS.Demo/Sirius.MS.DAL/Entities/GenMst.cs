using System;
using System.Collections.Generic;

namespace  Sirius.MS.DAL.Entities
{
    public partial class GenMst
    {
        public GenMst()
        {
            Customer = new HashSet<Customer>();
            Price = new HashSet<Price>();
            Product = new HashSet<Product>();
            PurDtl = new HashSet<PurDtl>();
            PurPayment = new HashSet<PurPayment>();
            PurReturnDtlGmidReturnTypeNavigation = new HashSet<PurReturnDtl>();
            PurReturnDtlGmidUnitNavigation = new HashSet<PurReturnDtl>();
            PurRptDtl = new HashSet<PurRptDtl>();
            SaleDtl = new HashSet<SaleDtl>();
            SalePayment = new HashSet<SalePayment>();
            SaleReturnDtlGmidReturnTypeNavigation = new HashSet<SaleReturnDtl>();
            SaleReturnDtlGmidUnitNavigation = new HashSet<SaleReturnDtl>();
            Stock = new HashSet<Stock>();
            StockTxn = new HashSet<StockTxn>();
            Supplier = new HashSet<Supplier>();
            Tax = new HashSet<Tax>();
            UsersGmidTitleNavigation = new HashSet<Users>();
            UsersGmidUserGroupNavigation = new HashSet<Users>();
        }

        public long Id { get; set; }
        public long? Gmpid { get; set; }
        public string Gmcat { get; set; }
        public string Gmsname { get; set; }
        public string Gmlname { get; set; }
        public string Gmdesc { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Price> Price { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<PurDtl> PurDtl { get; set; }
        public virtual ICollection<PurPayment> PurPayment { get; set; }
        public virtual ICollection<PurReturnDtl> PurReturnDtlGmidReturnTypeNavigation { get; set; }
        public virtual ICollection<PurReturnDtl> PurReturnDtlGmidUnitNavigation { get; set; }
        public virtual ICollection<PurRptDtl> PurRptDtl { get; set; }
        public virtual ICollection<SaleDtl> SaleDtl { get; set; }
        public virtual ICollection<SalePayment> SalePayment { get; set; }
        public virtual ICollection<SaleReturnDtl> SaleReturnDtlGmidReturnTypeNavigation { get; set; }
        public virtual ICollection<SaleReturnDtl> SaleReturnDtlGmidUnitNavigation { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTxn> StockTxn { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<Tax> Tax { get; set; }
        public virtual ICollection<Users> UsersGmidTitleNavigation { get; set; }
        public virtual ICollection<Users> UsersGmidUserGroupNavigation { get; set; }
    }
}
