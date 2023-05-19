using System;
using System.Collections.Generic;

#nullable disable

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class TruckModelPb
    {
        public TruckModelPb()
        {
            IndividualTruckPbs = new HashSet<IndividualTruckPb>();
        }

        public int ModelId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Size { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }

        public virtual ICollection<IndividualTruckPb> IndividualTruckPbs { get; set; }
    }
}
