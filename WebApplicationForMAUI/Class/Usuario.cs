using WebApplicationForMAUI.Shared;

namespace WebApplicationForMAUI.Class
{
    public class Usuario : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
