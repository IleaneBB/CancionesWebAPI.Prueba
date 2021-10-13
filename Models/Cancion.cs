using System.ComponentModel.DataAnnotations;

namespace CancionesWebAPI.Prueba.Models
{
    public class Cancion
    {
        [Key]
        public string CancionID { get; set; }
        [Display(Name = "Autor Principal")]
        public string Author { get; set; }
        [StringLength(90000, MinimumLength = 2, ErrorMessage = "INGRESE ENTRE 2 A 90000 CARACTERES")]
        [Display(Name = "Letra de la canción")]
        public string Lyrics { get; set; }
        [Display(Name = "Enlace de youtube")]
        public string URL { get; set; }
    }
}
