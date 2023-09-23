using Microsoft.AspNetCore.Mvc;
using WebApplicationForMAUI.Class;
using WebApplicationForMAUI.Context;

namespace WebApplicationForMAUI.Controllers
{
    [ApiController]
    [Route("/login")]

    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly ApplicationDbContext _context;


        public UsuarioController(ILogger<UsuarioController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet()]
        public IEnumerable<Usuario> GetUsuario()
        {
            return _context.Usuario.ToList();
        }

        [HttpPost()]
        public ActionResult PostUsuario(string username, string password, string email)
        {
            Usuario usuario = new Usuario();
            usuario.Name = username;
            usuario.Senha = password;
            usuario.Email = email;
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return Ok();
        }
    }
}