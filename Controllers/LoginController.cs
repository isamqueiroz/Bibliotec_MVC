using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Contexts;
using Bibliotec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bibliotec.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

   Context context = new Context();

        public IActionResult Index()
        {
            return View();
        }

[Route("Logar")]
    public IActionResult Logar(IFormCollection form)
    {
        string EmailInformado = form ["Email"]!;

        string SenhaInformada = form ["Senha"]!;

        Usuario usuarioBuscado = context.Usuario.FirstOrDefault(usuario => usuario.Email == EmailInformado && usuario.Senha == SenhaInformada)!;

    // List<Usuario> listaUsuario = context.Usuario.ToList();

    // foreach (Usuario usuario_ in listaUsuario){
    //     if(usuario_.Email == EmailInformado && usuario_.Senha == SenhaInformada){

    //     }else{

     //     }
    // }


    if(usuarioBuscado == null ){
        Console.WriteLine($"Dados Invalidos");
        return LocalRedirect("~/Login");
    }else{
        Console.WriteLine($"Eba!!! Voce Entrou :)");
        return LocalRedirect("~/Livro");
        
    }

    

    }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}