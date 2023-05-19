using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class TotalBetweenDates
    {
        [Key]
        public int ModelId { get; set; }
        public decimal TotalSales { get; set; }
    }
}
