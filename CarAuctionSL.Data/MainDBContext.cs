using CarAuctionSL.Model;
using CarAuctionSL.Model._MasterFiles;
using CarAuctionSL.Model._Process;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Data
{
    public class MainDBContext:DbContext
    {
        public MainDBContext():base("SysConn")
        {

        }
        public DbSet<ItemMaster> ItemMaster { get; set; }
        public DbSet<ItemExtended> ItemExtended { get; set; }
        public DbSet<Make> Make { get; set; }
        public DbSet<ModelMaster> ModelMaster { get; set; }
        public DbSet<Mileage> Mileage { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<YearMaster> YearMaster { get; set; }
        public DbSet<BodyTypeMaster> BodyTypeMaster { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Town> Town { get; set; }

        

        public DbSet<UserInterest> UserInterest { get; set; }
        public DbSet<ItemValuationDetail> ItemValuationDetail { get; set; }
        public DbSet<CustomerNotification> CustomerNotification { get; set; }
        public DbSet<CustomerBarginRequest> CustomerBarginRequest { get; set; }
        public DbSet<UploadList> UploadList { get; set; }
        


    }
}
