using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class Mileage
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(100)]
        public string DisplayName { get; set; }
        public decimal Fromistance { get; set; }
        public decimal ToDistance { get; set; }

    }
}

 
