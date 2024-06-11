using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Documents
{
    public class OrderHeadDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNumber { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        public DateTime Created {  get; set; }
        public ICollection<OrderDetailsDocument> OrderDetails { get; set; }
        public CustomerDocument Customer { get; set; }
    }
}
