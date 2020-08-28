using System;

namespace Sirius.MS.BAL.Models
{
    public partial class GenMstModel
    {      

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

    }
}
