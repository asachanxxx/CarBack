using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class Make
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(100)]
        public string DisplayName { get; set; }

      
    }
}
