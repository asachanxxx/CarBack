using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarAuctionSL.Model
{
    public class UserInterest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullCarName { get; set; }
        public int Makeid { get; set; }
        public int ModelId { get; set; }
        public int YearId { get; set; }
        public int MilageId { get; set; }
        /// <summary>
        /// 1- By Price
        /// 2- By Make and model Price
        /// </summary>
        public int InterestFactor { get; set; }

        /// <summary>
        /// this is the user asking min and max price for search
        /// </summary>
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

    }
}

