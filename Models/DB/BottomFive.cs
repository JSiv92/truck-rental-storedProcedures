using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class BottomFive
    {
        [Key]
        public int ModelId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}
