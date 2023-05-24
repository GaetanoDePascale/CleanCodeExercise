namespace RefactoringExercise.OriginalCode
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

        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var order in Orders)
            {
                foreach (var item in order.Items)
                {
                    decimal itemPrice = 0;

                    if (item.Discount > 0)
                    {
                        itemPrice = item.Price - (item.Price * item.Discount / 100);
                    }
                    else
                    {
                        itemPrice = item.Price;
                    }




                    if (order.ApplyTax)
                    {
                        itemPrice = itemPrice + (itemPrice * 0.1m);
                    }

                    total += itemPrice;
                }
            }

            return total;
        }
    }
}
