using rj.applicationdbcontext;
using rj.Model;

using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace rj.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DBContext _dbContext;


        public OrderRepository(DBContext context)
        {
            _dbContext=context;
        }



        public bool DeleteOrder(int ID)
        {
            bool result = false;
            var Student = _dbContext.Suman_Orders.Find(ID);
            if (Student != null)
            {
                _dbContext.Entry(Student).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }




        public async Task<IEnumerable<Suman_Orders>> GetOrder()
        {
            return await _dbContext.Suman_Orders.ToListAsync();
            
        }

        //public Task<Order> GetOrderByID(int ID)
        //{
        //    throw new NotImplementedException();
        //}




        public async Task<Suman_Orders> InsertOrder(Suman_Orders objorder)
        {
            await _dbContext.Suman_Orders.AddAsync(objorder);
            await _dbContext.SaveChangesAsync();
            return objorder;
        }



        public async Task<Suman_Orders> UpdateOrder(Suman_Orders objorder)
        {
            _dbContext.Entry(objorder).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return objorder;
        }
    }
}
