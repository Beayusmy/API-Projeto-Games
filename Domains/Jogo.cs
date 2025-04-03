//Namespace -> Caminho em que a classe jogo está.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDeJogos.Domains
{
    [Table ("Jogo")]
    //O Index faz com que o nome do jogo NAO se repita
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    //Public class -> Cria uma classe pública.
    public class Jogo
    {
        //Preencher os atributos
        [Key]
        public Guid JogoID { get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        //O reuqered faz com que seja obrigatorio preencher o campo NomeDoJogo
        [Required(ErrorMessage = "O nome do Jogo e obrigatorio")]
        public string? NomeDoJogo {  get; set; }
        
        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }
    }
}
