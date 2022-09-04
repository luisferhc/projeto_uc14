using projeto_uc14.Models;

namespace projeto_uc14.Interfaces
{
    public interface IUsuarioRepository
    {

        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);

        Usuario login(string email, string senha);
    }
}
