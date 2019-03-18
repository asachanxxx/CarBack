using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model
{
    public class CustomerNotification
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// this message based on this user interest 
        /// </summary>
        public int UserInterestId { get; set; }
        public string NotifyPhone { get; set; }
        public string NotifyEmail { get; set; }
        /// <summary>
        /// 1- Phone 2- Email
        /// </summary>
        public int NotifyVia { get; set; }
        public bool NotificationDone { get; set; }
    }
}
