using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Titulo Obrigatorio!")] //campo obrigatorio com Require
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo Diretor Obrigatorio!")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage ="O genero passou de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1,200, ErrorMessage = "O campo nao esta entre 1 a 200")] // campo duração deve estar entre 1 e 600
        public int Duracao { get; set; }

    }
}
