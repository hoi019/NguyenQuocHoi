using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class BillsMD
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string BDate { get; set; }
        public string BStatus { get; set; }
        public List<BillDetails> List_BillsDetails { get; set; }
    }
    public class BillDetails
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int DQuantity { get; set; }
        public int DPrice { get; set; }
    }
}
// xin chao moi nguoi