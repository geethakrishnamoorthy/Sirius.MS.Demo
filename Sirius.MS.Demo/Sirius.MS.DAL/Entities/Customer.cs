using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            SaleMst = new HashSet<SaleMst>();
        }

        public long Id { get; set; }
        public long? GmidTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Pincode { get; set; }
        public long? PmidCity { get; set; }
        public long? PmidState { get; set; }
        public long? PmidCountry { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual GenMst GmidTitleNavigation { get; set; }
        public virtual PlaceMst PmidCityNavigation { get; set; }
        public virtual PlaceMst PmidCountryNavigation { get; set; }
        public virtual PlaceMst PmidStateNavigation { get; set; }
        public virtual ICollection<SaleMst> SaleMst { get; set; }
    }
}
