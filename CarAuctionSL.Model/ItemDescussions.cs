using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class ItemDescussions
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public int IsPriceBargine { get; set; }
        public string Message { get; set; }
        public decimal BarginePrice { get; set; }
        public decimal BarginePercentage { get; set; }

    }
}
