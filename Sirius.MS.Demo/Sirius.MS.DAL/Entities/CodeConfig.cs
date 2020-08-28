using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class CodeConfig
    {
        public long Id { get; set; }
        public string CodeType { get; set; }
        public string FormType { get; set; }
        public string Prefix { get; set; }
        public int? Number { get; set; }
        public string Suffix { get; set; }
        public string StartCode { get; set; }
        public int? AddNumber { get; set; }
        public int? LastNumber { get; set; }
        public string Descr { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }
    }
}
