using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Documents
{
    /// <summary>
    /// Represents an order detail record in the database.
    /// </summary>
    public class OrderDetailsDocument
    {
        /// <summary>
        /// Unique identifier for the order detail record (primary key).
        /// </summary>
        public int OrderDtlID { get; set; }
        /// <summary>
        /// Order number associated with this detail.
        /// </summary>
        public int OrderNum { get; set; }
        /// <summary>
        /// Quantity of the item in this order detail.
        /// </summary>
        public int Qty { get; set; }
        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// Price of the item.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Reference to the order header document this detail belongs to (foreign key).
        /// </summary>
        public OrderHeadDocument OrderHead { get; set; }
    }
}
