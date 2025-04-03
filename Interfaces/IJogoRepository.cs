using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IJogoRepository
    {
        //1. Cadastrar();
        void Cadastrar(Jogo JogoNovo);
        //2. Listar();
        List<IJogoRepository> Listar();
        //3. Deletar();
        void Deletar(Guid id);
        //4. Atualizar();
        void Atualizar(Guid id, Jogo JogoAtualizado);

    }
}
