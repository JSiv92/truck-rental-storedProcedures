using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanSivananthanDADPartB.Models.DB
{
    public partial class SalesByMonth
    {
        [Key]
        public decimal TotalSalesForMonth { get; set; }
    }
}
