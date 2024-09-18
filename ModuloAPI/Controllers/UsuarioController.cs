using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{   
    //controller vai ser a porta de entrada para a api
    [ApiController] //precisa para criar controller
    [Route("[Controller]")] //precisa para criar controller
    //recomendado nomear com controller no final para identificação
    public class UsuarioController : ControllerBase //herda de controller base
    {
        //Controller = classe para agrupar requisições http e disponilibilizar os end points
        [HttpGet("ObterDataHoraAtual")] //vai disponibilizado no swagger
        public IActionResult ObterDataHora() //metodo
        {
            var obj = new{
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }


        [HttpGet("Apresentar/{nome}")]
        public ActionResult Apresentar(string nome){
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new {mensagem});
        }
    }
}
