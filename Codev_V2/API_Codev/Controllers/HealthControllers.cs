using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Codev.Data;

namespace API_Codev.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult>Get([FromServices]
        AppDbContext db)
        {
            var ok = await db.Database.CanConnectAsync();
            if(ok)
                return Ok(new { status = "db_on" });
            return
            StatusCode(503, new { status = "db_off" });
        }       
    }
}