namespace DemoApp.Pages.Contatti
{
    public class Contatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Sesso Sesso { get; set; }
        public bool Preferito { get; set; }
    }

    public enum Sesso 
    {
        Femmina,
        Maschio
    }
}