using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rj.Model;
using rj.Repository;

namespace rj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOrderRepository _order;
        public ValuesController(IOrderRepository order)
        {
            _order = order;
        }



        [HttpGet]
       [ Route("GetOrder")]
    public async Task<IActionResult> GetOrder()
                {
            return Ok(await _order.GetOrder());
        }

        [HttpPost]
        [Route("InsertOrder")]
            public async Task<IActionResult> InsertOrder(Suman_Orders objorder)
        {   
            return Ok(await _order.InsertOrder(objorder));
        }



        [HttpPut]
        [Route("UpdateOrder")]
        public async Task<IActionResult>UpdateOrder(Suman_Orders objorder)
        {
            return Ok(_order.UpdateOrder(objorder));
        }

        [HttpDelete]
        [Route("DeleteOrder")]
        public async Task<IActionResult>DeleteOrder(int id)
        {
          _order.DeleteOrder(id);
            return Ok();
        }
    }
}
