using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ProjetoJogosContext _context;

        public UsuarioRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Usuario UsuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario UsuarioNovo)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<IUsuarioRepository> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
