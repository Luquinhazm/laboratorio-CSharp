using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.ClassesDeExemplo
{
   public class Filme
    {
        [Required(ErrorMessage = "o titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "o titulo é obrigatório")]
        [MaxLength(50, ErrorMessage = "tamanho de genero invalido")]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "Duração Inválida")]
        public int Duracao { get; set; }
    }
}
