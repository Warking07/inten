

namespace inten.Domain.identities
{
    internal class Usuario
    {
        public int idUsuario { get; set; }
        public string? nombreApellidos { get; set; }
        public string? correos { get; set; }
        public string? clave { get; set; }
        public bool esActivo { get; set; }
        public DateTime? FechaCreacion { get; set; }


    }
}
