namespace DemoApp.Pages.Contatti
{
    public class Contatto
    {
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

    public static class ContattiProvider
    {
        public static List<Contatto> Contatti { get; } = new List<Contatto>
        {
            new Contatto {
                Nome = "Jane",
                Cognome = "Rivera",
                Telefono = "0800 675 5379",
                Email = "quisque.nonummy@hotmail.edu",
                Sesso = Sesso.Femmina,
                Preferito = true
            },
            new Contatto {
                Nome = "Katelyn",
                Cognome = "Molina",
                Telefono = "(01603) 426949",
                Email = "arcu.curabitur.ut@google.ca",
                Sesso = Sesso.Femmina,
                Preferito = true
            },
            new Contatto {
                Nome = "Geoffrey",
                Cognome = "Porter",
                Telefono = "0994 372 9709",
                Email = "donec@aol.com",
                Sesso = Sesso.Maschio,
                Preferito = true
            },
            new Contatto {
                Nome = "Hall",
                Cognome = "Goff",
                Telefono = "0800 1111",
                Email = "lacus.ut@icloud.ca",
                Sesso = Sesso.Maschio,
                Preferito = true
            },
            new Contatto {
                Nome = "Adrienne",
                Cognome = "Barlow",
                Telefono = "0845 46 47",
                Email = "hendrerit@aol.ca",
                Sesso = Sesso.Femmina,
                Preferito = true
            },
            new Contatto {
                Nome = "Lester",
                Cognome = "Russo",
                Telefono = "07681 312426",
                Email = "ipsum@outlook.edu",
                Sesso = Sesso.Maschio,
                Preferito = false
            },
            new Contatto {
                Nome = "Flavia",
                Cognome = "Perez",
                Telefono = "0374 046 0366",
                Email = "ut.quam@outlook.org",
                Sesso = Sesso.Femmina,
                Preferito = false
            },
            new Contatto {
                Nome = "Candice",
                Cognome = "Simmons",
                Telefono = "0845 46 44",
                Email = "velit.dui@icloud.ca",
                Sesso = Sesso.Femmina,
                Preferito = false
            },
            new Contatto {
                Nome = "Jason",
                Cognome = "Fischer",
                Telefono = "0800 1111",
                Email = "nascetur.ridiculus.mus@aol.edu",
                Sesso = Sesso.Maschio,
                Preferito = false
            },
            new Contatto {
                Nome = "Ignatius",
                Cognome = "Buckley",
                Telefono = "0862 284 2385",
                Email = "congue.turpis.in@hotmail.net",
                Sesso = Sesso.Maschio,
                Preferito = false
            }
        };
    }
}