using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Database_Topics_II.Models
{
    public class Query2Model
    {
        public DateTime OrderDate { get; set; }
        public string CategoryName { get; set; }
        public int TotalOrderQty { get; set; }
        public decimal TotalLineTotal { get; set; }
    }
}
