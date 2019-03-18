using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class CustomerBarginRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public decimal BarginePercentage { get; set; }
        public decimal BarginePrice { get; set; }
        /// <summary>
        /// If this bargin get approved by the user then this flag get updated
        /// </summary>
        public bool BarginAccepted { get; set; }
        /// <summary>
        /// If bargine accepted RevicedlPrice will updated and also the item's Selling price will be updated
        /// </summary>
        public decimal OriginalPrice { get; set; }
        public decimal RevicedlPrice { get; set; }
    }
}
