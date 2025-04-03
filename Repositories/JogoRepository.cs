using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ProjetoJogosContext _context;

        public JogoRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Jogo JogoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Jogo JogoNovo)
        {
            try
            {
                JogoNovo.JogoID = Guid.NewGuid();
                
                _context.jogos.Add(JogoNovo);

                _context.SaveChanges();
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

        public List<IJogoRepository> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
