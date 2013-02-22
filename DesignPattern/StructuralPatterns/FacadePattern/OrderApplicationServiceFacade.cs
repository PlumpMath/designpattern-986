using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.FacadePattern.OrderManagement;
using TSTune.DesignPattern.StructuralPatterns.FacadePattern.PriceManagement;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern
{
    public class OrderApplicationServiceFacade
    {
        /// <summary>
        /// This method is a facade which simplifies the placement of an order. 
        /// It orchestrates the steps needed to place an order.
        /// The OrderPlacement process consists of a validation, price calculation and the storage of the order.
        /// </summary>
        /// <param name="articleId">The article id</param>
        /// <param name="quantity">The quantity</param>
        /// <returns>True if order was succesfully stored and will be shipped</returns>
        public bool PlaceOrder(string articleId, int quantity)
        {
            Order order = new Order
            {
                ArticleId = articleId,
                Quantity = quantity
            };

            // Validate order
            bool result = OrderValidator.IsValidOrder(order);

            // Calculate Price
            result = result && CalculatePrice(order);

            // Place Order
            result = result & OrderStorage.PlaceOrder(order);

            return result;
        }

        private static bool CalculatePrice(Order order)
        {
            bool result = true;

            var priceCalculation = new PriceCalculation();
            var price = priceCalculation.CalculatePrice(order.ArticleId, order.Quantity);
            if (price == -1m)
            {
                result = false;
            }

            return result;
        }
    }
}
