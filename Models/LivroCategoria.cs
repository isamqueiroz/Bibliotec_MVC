using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        [Key]
        public int LivroCategoriaId { get; set; }
        public int LivroId { get; set; }
        
        [ForeignKey("Livro")]
        public  Livro Livro { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}