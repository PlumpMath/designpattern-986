using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.OrderManagement
{
    /// <summary>
    /// Order Dto (Data Transfer Object)
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the article id
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
