using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class ProductsMD
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ManufactuerId { get; set; }
        public string PName { get; set; }
        public int PPrice { get; set; }
        public int PQuantity { get; set; }
        public string PDescription { get; set; }
    }
}
