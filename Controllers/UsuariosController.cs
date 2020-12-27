using Microsoft.AspNetCore.Mvc;
using CrudUsuario.Services;
using CrudUsuario.Models;
using System.Collections.Generic;
using System;

namespace CrudUsuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {   private readonly IUsuarioService _service;
        public UsuariosController(IUsuarioService service)
        {
            this._service = service;
        }
        
        [HttpPost]
        public IActionResult CreateUsuario(Usuario usuario){
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            try {
                return Ok(_service.CreateUsuario(usuario));
            }catch(Exception){
                return BadRequest("Já existe um usuário com esse cpf ou rg");
            }
            
        }
        [HttpPost("{id}")]
        public IActionResult RemoveUsuario(int id){
           _service.RemoveUsuario(id);
           return Ok();
        }
        [HttpGet("cpf")]
        public IActionResult GetUsuarioByCpf(string cpf)
        {
            if(cpf == "" || cpf == null) 
            {
                return BadRequest("Informe o cpf");
            }
            return Ok(_service.GetUsuarioByCpf(cpf));
        }
        [HttpGet("rg")]
        public IActionResult GetUsuarioByRg(string rg)
        {
            if(rg == "" || rg == null)
            {
                return BadRequest("Informe o rg");
            }
            return Ok(_service.GetUsuarioByRg(rg));
        }
        [HttpGet]
         public IActionResult GetUsuariosByNome(string nome){
             return Ok(_service.GetUsuariosByNome(nome));
         }

    }
}