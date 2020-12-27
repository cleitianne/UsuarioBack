using System.Collections.Generic;
using CrudUsuario.Models;

namespace CrudUsuario.Services
{
    public interface IUsuarioService
    {
         Usuario CreateUsuario(Usuario usuario);
         void RemoveUsuario(int usuarioId);

         Usuario GetUsuarioByCpf(string cpf);
         Usuario GetUsuarioByRg(string rg);

         List<Usuario> GetUsuariosByNome(string nome);
    }
}