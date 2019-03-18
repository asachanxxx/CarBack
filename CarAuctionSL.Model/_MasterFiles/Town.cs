using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class Town
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        [StringLength(100)]
        public string DisplayName { get; set; }
    }
}
