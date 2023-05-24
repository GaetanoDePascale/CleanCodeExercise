
namespace RefactoringExercise.RefactoredCode
{
    class Customer
    {
        internal class Order
        {
            public List<Item> Items { get; set; }
            public bool ApplyTax { get; set; }
        }

        internal class Item
        {
            public decimal Price { get; set; }
            public decimal Discount { get; set; }
        }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public decimal CalculateOrdersTotalPrice()
        {
            decimal total = 0;

            foreach (var order in Orders)
            {
                total += CalculateOrderTotal(order);
            }

            return total;
        }

        private decimal CalculateOrderTotal(Order order)
        {
            decimal orderTotal = 0;

            foreach (var item in order.Items)
            {
                decimal itemPrice = CalculateItemPrice(item);

                if (order.ApplyTax)
                {
                    itemPrice = ApplyTax(itemPrice);
                }

                orderTotal += itemPrice;
            }

            return orderTotal;
        }

        private decimal CalculateItemPrice(Item item)
        {
            decimal itemPrice = item.Price;

            if (item.Discount > 0)
            {
                itemPrice = ApplyDiscount(itemPrice, item.Discount);
            }

            return itemPrice;
        }

        private decimal ApplyDiscount(decimal price, decimal discount)
        {
            return price - (price * discount / 100);
        }

        private decimal ApplyTax(decimal price)
        {
            const decimal taxRate = 0.1m;
            return price + (price * taxRate);
        }
    }
}
