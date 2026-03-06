using API_Codev.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace API_Codev.Controllers
{
    public record LoginRequest(string Username, string Password);
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest req, [FromServices] AppDbContext db)
        {
            var user = await db.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Username == req.Username && u.IsActive);
            if (user is null) return Unauthorized(new { message = "Usuário ou senha inválidos" });

            var ok = BCrypt.Net.BCrypt.Verify(req.Password, user.PasswordHash);

            if (!ok) return Unauthorized(new { message = "Usuário ou senha inválidos" });

            return Ok(new { userId = user.Id, username = user.Username });
        }
    }
}
