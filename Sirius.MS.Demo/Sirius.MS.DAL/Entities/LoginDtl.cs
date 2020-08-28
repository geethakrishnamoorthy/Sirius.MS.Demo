using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class LoginDtl
    {
        public long Id { get; set; }
        public long? UseId { get; set; }
        public string BillCtrCode { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public virtual Users Use { get; set; }
    }
}
