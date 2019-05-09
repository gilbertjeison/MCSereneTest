using Serenity.Services;

namespace MCSereneTest.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}