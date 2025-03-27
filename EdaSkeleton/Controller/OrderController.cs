using Microsoft.AspNetCore.Mvc;
using EdaSkeleton.Model;
using EdaSkeleton.Service;

namespace EdaSkeleton.Controller;

[ApiController]
[Route("order")]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public IActionResult CreateOrder([FromBody] OrderRequest request)
    {
        _orderService.CreateOrder(request.Product);
        return Ok("Order in process...");
    }
}
