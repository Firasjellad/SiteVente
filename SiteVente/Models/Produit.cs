using System.ComponentModel.DataAnnotations;

namespace SiteVente.Models
{
    public class Produit
    {
        [Key]
        [Required (ErrorMessage ="Le nom est obligatoire")]
        [StringLength(6,MinimumLength =3,ErrorMessage ="Le nom doit être entre 3 et 6 caractéres")]
        public string? Nom { get; set; }
        public int? Quantite { get; set; }
        public string? Marque { get; set; }
    }
}
