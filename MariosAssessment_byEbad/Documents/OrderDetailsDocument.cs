using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Documents
{
    public class OrderDetailsDocument
    {
        public int OrderDtlID { get; set; }
        public int OrderNum { get; set; }
        public int Qty { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public OrderHeadDocument OrderHead { get; set; }
    }
}
