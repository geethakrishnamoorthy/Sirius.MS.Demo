using System;
using System.Collections.Generic;

namespace Sirius.MS.DAL.Entities
{
    public partial class PlaceMst
    {
        public PlaceMst()
        {
            CompanyPmidCityNavigation = new HashSet<Company>();
            CompanyPmidCountryNavigation = new HashSet<Company>();
            CompanyPmidStateNavigation = new HashSet<Company>();
            CustomerPmidCityNavigation = new HashSet<Customer>();
            CustomerPmidCountryNavigation = new HashSet<Customer>();
            CustomerPmidStateNavigation = new HashSet<Customer>();
            StorePmidCityNavigation = new HashSet<Store>();
            StorePmidCountryNavigation = new HashSet<Store>();
            StorePmidStateNavigation = new HashSet<Store>();
            SupplierPmidCityNavigation = new HashSet<Supplier>();
            SupplierPmidCountryNavigation = new HashSet<Supplier>();
            SupplierPmidStateNavigation = new HashSet<Supplier>();
            UsersPmidCityNavigation = new HashSet<Users>();
            UsersPmidCountryNavigation = new HashSet<Users>();
            UsersPmidStateNavigation = new HashSet<Users>();
        }

        public long Id { get; set; }
        public long? Pmpid { get; set; }
        public string Pmcat { get; set; }
        public string Pmsname { get; set; }
        public string Pmlname { get; set; }
        public string Descr { get; set; }
        public string ActiveStatus { get; set; }
        public string DeleteStatus { get; set; }
        public long? CreaBy { get; set; }
        public DateTime? CreaDate { get; set; }
        public long? ModiBy { get; set; }
        public DateTime? ModiDate { get; set; }

        public virtual ICollection<Company> CompanyPmidCityNavigation { get; set; }
        public virtual ICollection<Company> CompanyPmidCountryNavigation { get; set; }
        public virtual ICollection<Company> CompanyPmidStateNavigation { get; set; }
        public virtual ICollection<Customer> CustomerPmidCityNavigation { get; set; }
        public virtual ICollection<Customer> CustomerPmidCountryNavigation { get; set; }
        public virtual ICollection<Customer> CustomerPmidStateNavigation { get; set; }
        public virtual ICollection<Store> StorePmidCityNavigation { get; set; }
        public virtual ICollection<Store> StorePmidCountryNavigation { get; set; }
        public virtual ICollection<Store> StorePmidStateNavigation { get; set; }
        public virtual ICollection<Supplier> SupplierPmidCityNavigation { get; set; }
        public virtual ICollection<Supplier> SupplierPmidCountryNavigation { get; set; }
        public virtual ICollection<Supplier> SupplierPmidStateNavigation { get; set; }
        public virtual ICollection<Users> UsersPmidCityNavigation { get; set; }
        public virtual ICollection<Users> UsersPmidCountryNavigation { get; set; }
        public virtual ICollection<Users> UsersPmidStateNavigation { get; set; }
    }
}
