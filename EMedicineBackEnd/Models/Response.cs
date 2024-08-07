namespace EMedicineBackEnd.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Users> listUsers { get; set; }
        public Users user { get; set; } 
        public List<Medicine> listMedicines { get; set; }
        public Medicine medicine { get; set; }
        public List<OrderItem> listItems { get; set; }
        public OrderItem orderItem { get; set; }
        public List<Orders> listOrders { get; set; }
        public Orders order { get; set; }
        public List<Cart> listCarts { get; set; }
        public Cart cart { get; set; }
    }
}
