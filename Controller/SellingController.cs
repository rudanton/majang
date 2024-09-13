using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class SellingController : ControllerBase
{
    private readonly DBContext _context;
    private readonly ILogger<SellingController> _logger;
    public SellingController(DBContext context, ILogger<SellingController> logger)
    {
        _context = context;
        _logger = logger;
    }
    [HttpGet("test")]
    public async Task<IActionResult> GetTest()
    {
        return Ok( new {
            Message = "Hello World"
        });
    }
}