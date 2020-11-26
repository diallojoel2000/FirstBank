using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactoryMr.Models
{
    public class SmsNotification
    {
        public long SmsNotificationId { get; set; }
        public long CustomerId { get; set; }
        public string PhoneNumber { get; set; }
        public string TransactionType { get; set; }
        public string AlertBy { get; set; }

        public Customer Customer { get; set; }
    }
}
