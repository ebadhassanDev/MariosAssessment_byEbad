using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Documents
{
    public class CustomerDocument
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string Name { get; set; } = default;
        public bool isActive { get; set; }

        public ICollection<OrderHeadDocument> Orders { get; set; }
    }
}
