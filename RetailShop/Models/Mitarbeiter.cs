using System.ComponentModel.DataAnnotations;

namespace RetailShop.Models
{
    public class Mitarbeiter
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Der Name ist erforderlich.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Der Vorname ist erforderlich.")]
        public string Vorname { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Geburtstag { get; set; }
    }
}
