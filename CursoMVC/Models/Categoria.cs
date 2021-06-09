using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Campo Obrigatório*")]
        public string Descricao { get; set; }
        //remover List produto
        //public List<Produto> Produto { get; set; }

    }
}
