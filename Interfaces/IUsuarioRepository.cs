using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IUsuarioRepository
    {
        //1. Cadastrar();
        void Cadastrar(Usuario UsuarioNovo);
        //2. Listar();
        List<IUsuarioRepository> Listar();
        //3. Deletar();
        void Deletar(Guid id);
        //4. Atualizar();
        void Atualizar(Guid id, Usuario UsuarioAtualizado);
    }
}
