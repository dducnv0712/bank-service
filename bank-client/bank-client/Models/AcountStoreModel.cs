using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bank_client.Models
{
    [Serializable]
    public class AcountStoreModel
    {
        public string AccountNumber { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string IndetityNumber { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; }
    }
}