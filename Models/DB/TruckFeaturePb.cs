using System;
using System.Collections.Generic;

#nullable disable

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class TruckFeaturePb
    {
        public TruckFeaturePb()
        {
            TruckFeatureAssociationPbs = new HashSet<TruckFeatureAssociationPb>();
        }

        public int FeatureId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TruckFeatureAssociationPb> TruckFeatureAssociationPbs { get; set; }
    }
}
