using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class ItemValuationDetail
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DateTime ValuationDate { get; set; }
        public string ValuationUploadedPath { get; set; }

    }
}
