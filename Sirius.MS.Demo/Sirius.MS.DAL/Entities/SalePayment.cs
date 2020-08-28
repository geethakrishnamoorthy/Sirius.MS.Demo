using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class SalePayment
    {
        public long Id { get; set; }
        public DateTime? SalePayDate { get; set; }
        public long? SaleMstId { get; set; }
        public long? GmidPayment { get; set; }
        public decimal? CashAmt { get; set; }
        public long? AccNo { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public decimal? BankAmt { get; set; }
        public string ChqNo { get; set; }
        public DateTime? ChqDate { get; set; }
        public decimal? ChqAmt { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual GenMst GmidPaymentNavigation { get; set; }
        public virtual SaleMst SaleMst { get; set; }
    }
}
