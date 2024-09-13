using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private readonly DBContext _context;
    private readonly ILogger<ItemController> _logger;
    public ItemController(DBContext context, ILogger<ItemController> logger)
    {
        _context = context;
        _logger = logger;
    }
    [HttpPost("add")]
    public async Task<IActionResult> AddItem([FromBody] ItemDto dto)
    {
        var item = new ItemData();
        item.ItemName = dto.ItemName;
        item.Price = dto.ItemPrice;

        _context.ItemDatas.Add(item);
        _context.SaveChanges();
        return Ok( new {
            Message = "Added"
        });
    }
}