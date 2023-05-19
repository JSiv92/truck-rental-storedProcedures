using System;
using System.Collections.Generic;

#nullable disable

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class TruckFeatureAssociationPb
    {
        public int TruckId { get; set; }
        public int FeatureId { get; set; }

        public virtual TruckFeaturePb Feature { get; set; }
    }
}
