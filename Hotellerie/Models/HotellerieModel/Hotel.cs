using System.ComponentModel.DataAnnotations;

namespace Hotellerie.Models.HotellerieModel
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "veuillez saisir le nom !")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "la longueur du nom doit etre comprise entre 3 et 20")]
        public string Nom { get; set; } = null!;
        [Range(1,5,ErrorMessage ="donner le nombre d'etoiles")]
        public int Etoiles {  get; set; }
        [Required(ErrorMessage = "veuillez saisir la ville !")]
        public string ville { get; set; } = null!;
        [Required(ErrorMessage ="le site web est obligatoire")]
        [Url(ErrorMessage ="veuillez saisir une Url valide pour le site web")]
        [Display(Name ="Site Web")]
        public string SiteWeb {  get; set; }=null!;
        public int Tel { get; set; }
        public string Pays { get; set; }


    }
}
