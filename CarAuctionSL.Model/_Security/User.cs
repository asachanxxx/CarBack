using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarAuctionSL.Model
{

    public class User
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public DateTime create_date { get; set; }
        [StringLength(100)]
        public string Last_Name { get; set; }
        [StringLength(100)]
        public string First_Name { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool IsRegistrationComplete { get; set; }
        /// <summary>
        /// 1-Active ,2- BlackListed 
        /// </summary>
        public int UserState { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string PasswordSalt { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        public string Access_Token { get; set; }

    }


}
