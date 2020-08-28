using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Config
    {
        public long Id { get; set; }
        public long? ConfigType { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
        public string Remarks { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }
    }
}
