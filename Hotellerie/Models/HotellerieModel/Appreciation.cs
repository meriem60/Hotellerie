using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotellerie.Models.HotellerieModel
{
    public class Appreciation
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "veuillez saisir le nom !")]
        [Display(Name = "Nom Personne")]
        public string NomPers { get; set; } = null!;
        [Required(ErrorMessage = "veuillez saisir un commentaire!")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; } = null!;
        [ForeignKey("Id")]
        public int HotelId { get; set; }
        [Required(ErrorMessage ="veuillez saisir une note !")]
        [Range(1,5)]
        public int Note { get; set; } 
    }
}
