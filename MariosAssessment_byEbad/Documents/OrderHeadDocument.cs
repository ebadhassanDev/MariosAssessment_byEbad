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
    /// Represents an order header record in the database.
    /// </summary>
    public class OrderHeadDocument
    {
        /// <summary>
        /// Unique identifier for the order (primary key, auto-generated).
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNumber { get; set; }
        /// <summary>
        /// Foreign key referencing the customer associated with the order (primary key).
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        /// <summary>
        /// Date and time the order was created.
        /// </summary>
        public DateTime Created {  get; set; }
        /// <summary>
        /// Collection of order detail records associated with this order header.
        /// </summary>
        public ICollection<OrderDetailsDocument> OrderDetails { get; set; }
        /// <summary>
        /// Reference to the customer document associated with this order (navigation property).
        /// </summary>
        public CustomerDocument Customer { get; set; }
    }
}
