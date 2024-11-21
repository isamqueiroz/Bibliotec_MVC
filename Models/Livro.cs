using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bibliotec.Models
{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }
        public string? Nome { get; set;}
        public string? Escritor { get; set;}
        public string? Editora { get; set;}
        public string? Descricao { get; set;}
        public string? Idioma { get; set;}
        public string? Imagem { get; set;}
        public bool Reservado   { get; set;}
        public bool ativo { get; set;}
    }
}