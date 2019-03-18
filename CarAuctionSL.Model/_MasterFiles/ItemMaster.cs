using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarAuctionSL.Model
{
    public class ItemMaster
    {

        public int Id { get; set; }
        [StringLength(100)]
        public string CustomerId { get; set; }
        [StringLength(200)]
        public string DisplayName { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public int BodyTypeId { get; set; }
        public int Milage { get; set; }
        public int Option { get; set; }
        /// <summary>
        /// If any point user can decide the item goes to auction
        /// </summary>
        public bool IsAuction { get; set; }
        /// <summary>
        /// If price bargined update this to true and show near item
        /// </summary>
        public bool IsPriceBargined { get; set; }
        /// <summary>
        /// If valuation uploaded update this and how in near ITem
        /// </summary>
        public bool IsValuationDone { get; set; }
        /// <summary>
        /// this is the system estimated price
        /// </summary>
        public decimal EstimatePrice { get; set; }
        /// <summary>
        /// This is Customer Given Price
        /// </summary>
        public decimal CustomerPrice { get; set; }
        /// <summary>
        /// This is auction start price
        /// </summary>
        public decimal AuctionPrice { get; set; }
        /// <summary>
        /// Last Item Sell price if it bargined , auctioned
        /// </summary>
        public decimal SellingPrice { get; set; }

        /// <summary>
        /// Rank 1-5 . the idea here is to look at the inspection sheet and update this status Manually
        /// </summary>
        public int ItemConditionRank { get; set; }

        public int EngineCapacity { get; set; }

        /// <summary>
        /// Manual . Auto
        /// </summary>
        public string Transmission { get; set; }

        /// <summary>
        /// Petrol Diesel 
        /// </summary>
        public string FuelTyoe { get; set; }

        public int DoorCount { get; set; }

        public string MoreDetails { get; set; }
    }




}
