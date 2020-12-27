using System;
using System.Collections.Generic;
using System.Linq;
using CrudUsuario.Context;
using CrudUsuario.Models;

namespace CrudUsuario.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;
        public UsuarioRepository(DataContext context){
            this._context = context;
        }
        public Usuario CreateUsuario(Usuario usuario){
            usuario.DataCadastro = DateTime.Now;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }
        public void RemoveUsuario(int usuarioId){
            var usuario = _context.Usuarios.Find(usuarioId);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

         public Usuario GetUsuarioByCpf(string cpf){
             var usuario = _context.Usuarios.Where(u => u.Cpf == cpf).FirstOrDefault();
             return usuario;
         }

        public Usuario GetUsuarioByRg(string rg){
            var usuario = _context.Usuarios.Where(u => u.Rg == rg).FirstOrDefault();
            return usuario;
        }

        public Usuario GetUsuarioByCpfOrRg(Usuario usuario){
           return _context.Usuarios.Where(u => u.Rg == usuario.Rg || u.Cpf == usuario.Cpf).FirstOrDefault();
            
        }

         public List<Usuario> GetUsuariosByNome(string nome){
            var usuarios = _context.Usuarios.AsQueryable();
            if(nome != "" && nome != null) 
            {
                usuarios = usuarios.Where(u => u.Nome.ToLower().Contains(nome.ToLower()));
            }   
                
             return usuarios.ToList();
         }

    }
}