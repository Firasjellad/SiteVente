using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteVente.Models
{
    public class Client
    {      
        [Key]
        [Required(ErrorMessage ="le nom est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "le type du client est obligatoire")]
        [EnumDataType(typeof(TYPE_CLIENT))]

        public TYPE_CLIENT TypeClient { get; set; }
        public string Adresse { get; set; }
        [NotMapped]
        public ADRESS? AdresseStruct { get; set; }
    }
    public enum TYPE_CLIENT
    {
        professionnel ,
        particulier
    }

    public struct ADRESS
    {
        public override string ToString()
        {
            return this.Rue + " , " + this.Ville + " , " + this.Pays;
        }
        public string? Rue { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
    }
}
