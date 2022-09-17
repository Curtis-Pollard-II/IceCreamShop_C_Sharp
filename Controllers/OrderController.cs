using System;
using System.Collections.Generic;
using IceCreamShop_C_Sharp.Models;
using IceCreamShop_C_Sharp.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IceCreamShop_C_Sharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrdersService _ordersService;

        public OrderController(OrdersService ordersService)
        {
            _ordersService = ordersService;
        }


        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            try 
            {
              List<Order> orders = _ordersService.GetOrders();
              return Ok(orders);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
}