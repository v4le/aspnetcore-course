using System.ComponentModel.DataAnnotations;

namespace DemoApp.Pages.Contatti
{
    public class Contatto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Il campo nome è obbligatorio")]
        [StringLength(20, ErrorMessage = "Il nome non può superare i 20 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Il campo cognome è obbligatorio")]
        [StringLength(22, ErrorMessage = "Il cognome non può superare i 22 caratteri")]
        public string Cognome { get; set; }

        [EmailAddress(ErrorMessage = "La mail deve avere un formato valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Il campo telefono è obbligatorio")]
        [RegularExpression("^0\\d{1,2}[1-9]\\d{5,8}$", ErrorMessage = "Il telefono deve essere in formato italiano")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Il campo Sesso è obbligatorio")]
        public Sesso Sesso { get; set; }

        [Required(ErrorMessage = "Il campo Preferito è obbligatorio")]
        public bool Preferito { get; set; }
    }

    public enum Sesso 
    {
        Femmina,
        Maschio
    }
}