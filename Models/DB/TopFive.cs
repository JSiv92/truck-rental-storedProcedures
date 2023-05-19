using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class TopFive
    {
        [Key]
        public int TruckId { get; set; }

        //public int RentDate { get; set; }
        public string RegistrationNumber { get; set; }

    }
}
