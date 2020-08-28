using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Store
    {
        public long Id { get; set; }
        public string StoreCode { get; set; }
        public string StoreSname { get; set; }
        public string StoreLname { get; set; }
        public string PrimeStore { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public long? Pincode { get; set; }
        public long? PmidCity { get; set; }
        public long? PmidState { get; set; }
        public long? PmidCountry { get; set; }
        public string EmailId { get; set; }
        public string StoreMgr { get; set; }
        public string StoreMgrPhone { get; set; }
        public string StoreMgrEmail { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual PlaceMst PmidCityNavigation { get; set; }
        public virtual PlaceMst PmidCountryNavigation { get; set; }
        public virtual PlaceMst PmidStateNavigation { get; set; }
    }
}
