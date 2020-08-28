using Microsoft.EntityFrameworkCore;
using Sirius.MS.DAL.Entities;
using Sirius.MS.DAL.Repositories;

namespace Sirius.MS.DAL.DBContext
{
    public partial class VBooksDBContext : DbContext
    {
        public VBooksDBContext()
        {
        }

        public VBooksDBContext(DbContextOptions<VBooksDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BillCounter> BillCounter { get; set; }
        public virtual DbSet<CodeConfig> CodeConfig { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<GenMst> GenMst { get; set; }
        public virtual DbSet<LoginDtl> LoginDtl { get; set; }
        public virtual DbSet<PlaceMst> PlaceMst { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<ProdBrand> ProdBrand { get; set; }
        public virtual DbSet<ProdDiscount> ProdDiscount { get; set; }
        public virtual DbSet<ProdGroup> ProdGroup { get; set; }
        public virtual DbSet<ProdSupplier> ProdSupplier { get; set; }
        public virtual DbSet<ProdTax> ProdTax { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<PurDtl> PurDtl { get; set; }
        public virtual DbSet<PurMst> PurMst { get; set; }
        public virtual DbSet<PurPayment> PurPayment { get; set; }
        public virtual DbSet<PurReturnDtl> PurReturnDtl { get; set; }
        public virtual DbSet<PurReturnMst> PurReturnMst { get; set; }
        public virtual DbSet<PurRptDtl> PurRptDtl { get; set; }
        public virtual DbSet<PurRptMst> PurRptMst { get; set; }
        public virtual DbSet<SaleDtl> SaleDtl { get; set; }
        public virtual DbSet<SaleMst> SaleMst { get; set; }
        public virtual DbSet<SalePayment> SalePayment { get; set; }
        public virtual DbSet<SaleReturnDtl> SaleReturnDtl { get; set; }
        public virtual DbSet<SaleReturnMst> SaleReturnMst { get; set; }
        public virtual DbSet<SizeConfig> SizeConfig { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockTxn> StockTxn { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(VbooksDBConfig.VBooksDBConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillCounter>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillCtrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCtrName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CodeConfig>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descr).HasColumnType("text");

                entity.Property(e => e.FormType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompLname)
                    .HasColumnName("CompLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompSname)
                    .HasColumnName("CompSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GstNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmidCity).HasColumnName("PMIdCity");

                entity.Property(e => e.PmidCountry).HasColumnName("PMIdCountry");

                entity.Property(e => e.PmidState).HasColumnName("PMIdState");

                entity.Property(e => e.ServicetaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TinNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteId)
                    .HasColumnName("websiteID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.PmidCityNavigation)
                    .WithMany(p => p.CompanyPmidCityNavigation)
                    .HasForeignKey(d => d.PmidCity)
                    .HasConstraintName("FK__Company__PMIdCit__5165187F");

                entity.HasOne(d => d.PmidCountryNavigation)
                    .WithMany(p => p.CompanyPmidCountryNavigation)
                    .HasForeignKey(d => d.PmidCountry)
                    .HasConstraintName("FK__Company__PMIdCou__52593CB8");

                entity.HasOne(d => d.PmidStateNavigation)
                    .WithMany(p => p.CompanyPmidStateNavigation)
                    .HasForeignKey(d => d.PmidState)
                    .HasConstraintName("FK__Company__PMIdSta__534D60F1");
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GmidTitle).HasColumnName("GMIdTitle");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmidCity).HasColumnName("PMIdCity");

                entity.Property(e => e.PmidCountry).HasColumnName("PMIdCountry");

                entity.Property(e => e.PmidState).HasColumnName("PMIdState");

                entity.HasOne(d => d.GmidTitleNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.GmidTitle)
                    .HasConstraintName("FK__Customer__GMIdTi__5441852A");

                entity.HasOne(d => d.PmidCityNavigation)
                    .WithMany(p => p.CustomerPmidCityNavigation)
                    .HasForeignKey(d => d.PmidCity)
                    .HasConstraintName("FK__Customer__PMIdCi__5535A963");

                entity.HasOne(d => d.PmidCountryNavigation)
                    .WithMany(p => p.CustomerPmidCountryNavigation)
                    .HasForeignKey(d => d.PmidCountry)
                    .HasConstraintName("FK__Customer__PMIdCo__5629CD9C");

                entity.HasOne(d => d.PmidStateNavigation)
                    .WithMany(p => p.CustomerPmidStateNavigation)
                    .HasForeignKey(d => d.PmidState)
                    .HasConstraintName("FK__Customer__PMIdSt__571DF1D5");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DisEnd).HasColumnType("datetime");

                entity.Property(e => e.DisGift)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisPercent)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DisStart).HasColumnType("datetime");

                entity.Property(e => e.DisType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Gmcat)
                    .HasColumnName("GMCat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gmdesc)
                    .HasColumnName("GMDesc")
                    .HasColumnType("text");

                entity.Property(e => e.Gmlname)
                    .HasColumnName("GMLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gmpid).HasColumnName("GMPId");

                entity.Property(e => e.Gmsname)
                    .HasColumnName("GMSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoginDtl>(entity =>
            {
                entity.Property(e => e.BillCtrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Use)
                    .WithMany(p => p.LoginDtl)
                    .HasForeignKey(d => d.UseId)
                    .HasConstraintName("FK__LoginDtl__UseId__5812160E");
            });

            modelBuilder.Entity<PlaceMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Descr).HasColumnType("text");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Pmcat)
                    .HasColumnName("PMCat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pmlname)
                    .HasColumnName("PMLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pmpid).HasColumnName("PMPId");

                entity.Property(e => e.Pmsname)
                    .HasColumnName("PMSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Mrprate)
                    .HasColumnName("MRPRate")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.SaleRate).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.Price)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__Price__GMIdUnit__59063A47");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Price)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__Price__ProdId__59FA5E80");
            });

            modelBuilder.Entity<ProdBrand>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandLname)
                    .HasColumnName("BrandLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandSname)
                    .HasColumnName("BrandSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdDiscount>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.HasOne(d => d.Dis)
                    .WithMany(p => p.ProdDiscount)
                    .HasForeignKey(d => d.DisId)
                    .HasConstraintName("FK__ProdDisco__DisId__5AEE82B9");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdDiscount)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__ProdDisco__ProdI__5BE2A6F2");
            });

            modelBuilder.Entity<ProdGroup>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupLname)
                    .HasColumnName("GroupLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupSname)
                    .HasColumnName("GroupSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdSupplier>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdSupplier)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__ProdSuppl__ProdI__5CD6CB2B");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProdSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__ProdSuppl__Suppl__5DCAEF64");
            });

            modelBuilder.Entity<ProdTax>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdTax)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__ProdTax__ProdId__5EBF139D");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.ProdTax)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK__ProdTax__TaxId__5FB337D6");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdLname)
                    .HasColumnName("ProdLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdSname)
                    .HasColumnName("ProdSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__Product__GMIdUni__60A75C0F");
            });

            modelBuilder.Entity<PurDtl>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.PurDtl)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__PurDtl__GMIdUnit__619B8048");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.PurDtl)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__PurDtl__ProdId__628FA481");

                entity.HasOne(d => d.PurOdr)
                    .WithMany(p => p.PurDtl)
                    .HasForeignKey(d => d.PurOdrId)
                    .HasConstraintName("FK__PurDtl__PurOdrId__6383C8BA");
            });

            modelBuilder.Entity<PurMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.PurDate).HasColumnType("datetime");

                entity.Property(e => e.PurOdrNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.HasOne(d => d.Sup)
                    .WithMany(p => p.PurMst)
                    .HasForeignKey(d => d.SupId)
                    .HasConstraintName("FK__PurMst__SupId__6477ECF3");
            });

            modelBuilder.Entity<PurPayment>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BankAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cashamt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ChqAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ChqDate).HasColumnType("datetime");

                entity.Property(e => e.ChqNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidPayment).HasColumnName("GMIdPayment");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.PurPayDate).HasColumnType("datetime");

                entity.Property(e => e.PurRecNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.GmidPaymentNavigation)
                    .WithMany(p => p.PurPayment)
                    .HasForeignKey(d => d.GmidPayment)
                    .HasConstraintName("FK__PurPaymen__GMIdP__656C112C");

                entity.HasOne(d => d.PurOdr)
                    .WithMany(p => p.PurPayment)
                    .HasForeignKey(d => d.PurOdrId)
                    .HasConstraintName("FK__PurPaymen__PurOd__66603565");
            });

            modelBuilder.Entity<PurReturnDtl>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidReturnType).HasColumnName("GMIdReturnType");

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.HasOne(d => d.GmidReturnTypeNavigation)
                    .WithMany(p => p.PurReturnDtlGmidReturnTypeNavigation)
                    .HasForeignKey(d => d.GmidReturnType)
                    .HasConstraintName("FK__PurReturn__GMIdR__6754599E");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.PurReturnDtlGmidUnitNavigation)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__PurReturn__GMIdU__68487DD7");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.PurReturnDtl)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__PurReturn__ProdI__693CA210");

                entity.HasOne(d => d.PurReturnMst)
                    .WithMany(p => p.PurReturnDtl)
                    .HasForeignKey(d => d.PurReturnMstId)
                    .HasConstraintName("FK__PurReturn__PurRe__6A30C649");
            });

            modelBuilder.Entity<PurReturnMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.PurReturnDate).HasColumnType("datetime");

                entity.Property(e => e.PurReturnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PurRptMst)
                    .WithMany(p => p.PurReturnMst)
                    .HasForeignKey(d => d.PurRptMstId)
                    .HasConstraintName("FK__PurReturn__PurRp__6B24EA82");
            });

            modelBuilder.Entity<PurRptDtl>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.PurRptDtl)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__PurRptDtl__GMIdU__6C190EBB");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.PurRptDtl)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__PurRptDtl__ProdI__6D0D32F4");

                entity.HasOne(d => d.PurRptMst)
                    .WithMany(p => p.PurRptDtl)
                    .HasForeignKey(d => d.PurRptMstId)
                    .HasConstraintName("FK__PurRptDtl__PurRp__6E01572D");
            });

            modelBuilder.Entity<PurRptMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.PurRptDate).HasColumnType("datetime");

                entity.Property(e => e.PurRptNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.HasOne(d => d.PurOdr)
                    .WithMany(p => p.PurRptMst)
                    .HasForeignKey(d => d.PurOdrId)
                    .HasConstraintName("FK__PurRptMst__PurOd__6EF57B66");
            });

            modelBuilder.Entity<SaleDtl>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Amt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.TaxAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.SaleDtl)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__SaleDtl__GMIdUni__6FE99F9F");

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.SaleDtl)
                    .HasForeignKey(d => d.PriceId)
                    .HasConstraintName("FK__SaleDtl__PriceId__70DDC3D8");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.SaleDtl)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__SaleDtl__ProdId__71D1E811");

                entity.HasOne(d => d.SaleMst)
                    .WithMany(p => p.SaleDtl)
                    .HasForeignKey(d => d.SaleMstId)
                    .HasConstraintName("FK__SaleDtl__SaleMst__72C60C4A");
            });

            modelBuilder.Entity<SaleMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.SaleAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.BillCtr)
                    .WithMany(p => p.SaleMst)
                    .HasForeignKey(d => d.BillCtrId)
                    .HasConstraintName("FK__SaleMst__BillCtr__73BA3083");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.SaleMst)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK__SaleMst__CustId__74AE54BC");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SaleMst)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__SaleMst__UserId__75A278F5");
            });

            modelBuilder.Entity<SalePayment>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BankAmt).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CashAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ChqAmt).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ChqDate).HasColumnType("datetime");

                entity.Property(e => e.ChqNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidPayment).HasColumnName("GMIdPayment");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.SalePayDate).HasColumnType("datetime");

                entity.HasOne(d => d.GmidPaymentNavigation)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.GmidPayment)
                    .HasConstraintName("FK__SalePayme__GMIdP__76969D2E");

                entity.HasOne(d => d.SaleMst)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.SaleMstId)
                    .HasConstraintName("FK__SalePayme__SaleM__778AC167");
            });

            modelBuilder.Entity<SaleReturnDtl>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Amt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidReturnType).HasColumnName("GMIdReturnType");

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.HasOne(d => d.GmidReturnTypeNavigation)
                    .WithMany(p => p.SaleReturnDtlGmidReturnTypeNavigation)
                    .HasForeignKey(d => d.GmidReturnType)
                    .HasConstraintName("FK__SaleRetur__GMIdR__787EE5A0");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.SaleReturnDtlGmidUnitNavigation)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__SaleRetur__GMIdU__797309D9");

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.SaleReturnDtl)
                    .HasForeignKey(d => d.PriceId)
                    .HasConstraintName("FK__SaleRetur__Price__7A672E12");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.SaleReturnDtl)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__SaleRetur__ProdI__7B5B524B");

                entity.HasOne(d => d.SaleReturnMst)
                    .WithMany(p => p.SaleReturnDtl)
                    .HasForeignKey(d => d.SaleReturnMstId)
                    .HasConstraintName("FK__SaleRetur__SaleR__7C4F7684");
            });

            modelBuilder.Entity<SaleReturnMst>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.SaleReturnDate).HasColumnType("datetime");

                entity.HasOne(d => d.SaleMst)
                    .WithMany(p => p.SaleReturnMst)
                    .HasForeignKey(d => d.SaleMstId)
                    .HasConstraintName("FK__SaleRetur__SaleM__7D439ABD");
            });

            modelBuilder.Entity<SizeConfig>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabelId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__Stock__GMIdUnit__7E37BEF6");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__Stock__ProdId__7F2BE32F");

                entity.HasOne(d => d.PurRptMst)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.PurRptMstId)
                    .HasConstraintName("FK__Stock__PurRptMst__00200768");
            });

            modelBuilder.Entity<StockTxn>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidUnit).HasColumnName("GMIdUnit");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Txntype)
                    .HasColumnName("txntype")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.GmidUnitNavigation)
                    .WithMany(p => p.StockTxn)
                    .HasForeignKey(d => d.GmidUnit)
                    .HasConstraintName("FK__StockTxn__GMIdUn__01142BA1");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.StockTxn)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__StockTxn__ProdId__02084FDA");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.StockTxn)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK__StockTxn__StockI__02FC7413");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmidCity).HasColumnName("PMIdCity");

                entity.Property(e => e.PmidCountry).HasColumnName("PMIdCountry");

                entity.Property(e => e.PmidState).HasColumnName("PMIdState");

                entity.Property(e => e.PrimeStore)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreLname)
                    .HasColumnName("StoreLName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMgr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMgrEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMgrPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StoreSname)
                    .HasColumnName("StoreSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PmidCityNavigation)
                    .WithMany(p => p.StorePmidCityNavigation)
                    .HasForeignKey(d => d.PmidCity)
                    .HasConstraintName("FK__Store__PMIdCity__03F0984C");

                entity.HasOne(d => d.PmidCountryNavigation)
                    .WithMany(p => p.StorePmidCountryNavigation)
                    .HasForeignKey(d => d.PmidCountry)
                    .HasConstraintName("FK__Store__PMIdCount__04E4BC85");

                entity.HasOne(d => d.PmidStateNavigation)
                    .WithMany(p => p.StorePmidStateNavigation)
                    .HasForeignKey(d => d.PmidState)
                    .HasConstraintName("FK__Store__PMIdState__05D8E0BE");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GmidTitle).HasColumnName("GMIdTitle");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmidCity).HasColumnName("PMIdCity");

                entity.Property(e => e.PmidCountry).HasColumnName("PMIdCountry");

                entity.Property(e => e.PmidState).HasColumnName("PMIdState");

                entity.HasOne(d => d.GmidTitleNavigation)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.GmidTitle)
                    .HasConstraintName("FK__Supplier__GMIdTi__06CD04F7");

                entity.HasOne(d => d.PmidCityNavigation)
                    .WithMany(p => p.SupplierPmidCityNavigation)
                    .HasForeignKey(d => d.PmidCity)
                    .HasConstraintName("FK__Supplier__PMIdCi__07C12930");

                entity.HasOne(d => d.PmidCountryNavigation)
                    .WithMany(p => p.SupplierPmidCountryNavigation)
                    .HasForeignKey(d => d.PmidCountry)
                    .HasConstraintName("FK__Supplier__PMIdCo__08B54D69");

                entity.HasOne(d => d.PmidStateNavigation)
                    .WithMany(p => p.SupplierPmidStateNavigation)
                    .HasForeignKey(d => d.PmidState)
                    .HasConstraintName("FK__Supplier__PMIdSt__09A971A2");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GmidType).HasColumnName("GMIdType");

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.TaxName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.GmidTypeNavigation)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.GmidType)
                    .HasConstraintName("FK__Tax__GMIdType__0A9D95DB");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreaDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GmidTitle).HasColumnName("GMIdTitle");

                entity.Property(e => e.GmidUserGroup).HasColumnName("GMIdUserGroup");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmidCity).HasColumnName("PMIdCity");

                entity.Property(e => e.PmidCountry).HasColumnName("PMIdCountry");

                entity.Property(e => e.PmidState).HasColumnName("PMIdState");

                entity.HasOne(d => d.GmidTitleNavigation)
                    .WithMany(p => p.UsersGmidTitleNavigation)
                    .HasForeignKey(d => d.GmidTitle)
                    .HasConstraintName("FK__Users__GMIdTitle__0B91BA14");

                entity.HasOne(d => d.GmidUserGroupNavigation)
                    .WithMany(p => p.UsersGmidUserGroupNavigation)
                    .HasForeignKey(d => d.GmidUserGroup)
                    .HasConstraintName("FK__Users__GMIdUserG__0C85DE4D");

                entity.HasOne(d => d.PmidCityNavigation)
                    .WithMany(p => p.UsersPmidCityNavigation)
                    .HasForeignKey(d => d.PmidCity)
                    .HasConstraintName("FK__Users__PMIdCity__0D7A0286");

                entity.HasOne(d => d.PmidCountryNavigation)
                    .WithMany(p => p.UsersPmidCountryNavigation)
                    .HasForeignKey(d => d.PmidCountry)
                    .HasConstraintName("FK__Users__PMIdCount__0E6E26BF");

                entity.HasOne(d => d.PmidStateNavigation)
                    .WithMany(p => p.UsersPmidStateNavigation)
                    .HasForeignKey(d => d.PmidState)
                    .HasConstraintName("FK__Users__PMIdState__0F624AF8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
