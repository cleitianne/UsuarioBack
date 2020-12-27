using System;
using System.Collections.Generic;
using CrudUsuario.Models;
using CrudUsuario.Repositories;

namespace CrudUsuario.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            this._repository = repository;
        }

        public Usuario CreateUsuario(Usuario usuario){
            var existeUsuario = _repository.GetUsuarioByCpfOrRg(usuario);
            if(existeUsuario != null)
                throw new Exception();
            return _repository.CreateUsuario(usuario);
        }
        public void RemoveUsuario(int usuarioId){
            _repository.RemoveUsuario(usuarioId);
        }

         public Usuario GetUsuarioByCpf(string cpf){
             return _repository.GetUsuarioByCpf(cpf);
         }
         public Usuario GetUsuarioByRg(string rg){
             return _repository.GetUsuarioByRg(rg);
         }

         public List<Usuario> GetUsuariosByNome(string nome){
             return _repository.GetUsuariosByNome(nome);
         }
    }
}