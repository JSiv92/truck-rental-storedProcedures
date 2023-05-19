using System;
using System.Collections.Generic;

#nullable disable

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class TruckCustomerPb
    {
        public int CustomerId { get; set; }
        public string LicenseNumber { get; set; }
        public int Age { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
    }
}
