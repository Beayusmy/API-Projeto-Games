using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDeJogos.Domains
{
    [Table("Usuario")]
    [Index(nameof(NickName), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Nickname e obrigatorio")]

        public string? Nome { get; set; }
        
        public string? NickName { get; set; }

        public Guid JogoFavorito  { get; set; }

        [ForeignKey("JogoFavorito")]
        public Jogo? Jogo { get; set; }
    }
}
