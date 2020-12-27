using System.Collections.Generic;
using CrudUsuario.Models;

namespace CrudUsuario.Repositories
{
    public interface IUsuarioRepository
    {
         Usuario CreateUsuario(Usuario usuario);
         void RemoveUsuario(int usuarioId);

         Usuario GetUsuarioByCpf(string cpf);
         Usuario GetUsuarioByRg(string rg);
         Usuario GetUsuarioByCpfOrRg(Usuario usuario);

         List<Usuario> GetUsuariosByNome(string nome);

         
    }
}