using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Documents
{
    /// <summary>
    /// Represents a customer record in the database.
    /// </summary>
    public class CustomerDocument
    {
        /// <summary>
        /// Unique identifier for the customer (primary key).
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        /// <summary>
        /// Name of the customer.
        /// </summary>
        public string Name { get; set; } = default;
        /// <summary>
        /// Indicates whether the customer is active.
        /// </summary>
        public bool isActive { get; set; }
        /// <summary>
        /// Collection of order headers associated with this customer.
        /// </summary>

        public ICollection<OrderHeadDocument> Orders { get; set; }
    }
}
