using rj.Model;

namespace rj.Repository
{
    public interface IOrderRepository
    {

        Task<IEnumerable<Suman_Orders>> GetOrder();
       // Task<Order> GetOrderByID(int ID);
        Task<Suman_Orders> InsertOrder(Suman_Orders objorder);
        Task<Suman_Orders> UpdateOrder(Suman_Orders objorder);
        bool DeleteOrder(int ID);
    }
}
