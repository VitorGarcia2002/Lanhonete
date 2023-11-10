using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.OpenApi.Any;
using WebApplication1.Context;
using WebApplication1.Models;

namespace APIStock.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController:ControllerBase
	{
		private readonly DataContext _dbContext;

		public LoginController(DataContext dbContext)
		{
			_dbContext = dbContext;
		}

		// GET: api/Brand
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Login>>> GetLogin()
		{
			var login = await _dbContext.Logins.ToListAsync();

			return Ok(login);
		}
	}
}