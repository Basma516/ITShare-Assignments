namespace Restaurant_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
// Restaurant

//Menu

//MenuItem

//Order

//PaymentService
        }
    }
    class MenueItem //aggregation with restaurant and order
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Order
    {
        public List<MenueItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
    class paymentService //Dependency with restaurant and order 
    {
        public void ProcessPayment(Order order)
        {
            // Logic to process payment
        }
    }

    class Restaurant
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<MenueItem> Menus { get; set; }
        public void AddMenuItem(MenueItem item)
        {
            Menus.Add(item);
        }

        public void PlaceOrder(Order order)
        {
            // Logic to process the order
        }
        public void MakePayment(Order order, paymentService paymentService)
        {
            paymentService.ProcessPayment(order);
        }

    }
}
