namespace DemoApp.Pages.Contatti
{
    public class Contatto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DataNascita { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
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
                DataNascita = DateOnly.ParseExact("09/08/1938", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Katelyn",
                Cognome = "Molina",
                Telefono = "(01603) 426949",
                Email = "arcu.curabitur.ut@google.ca",
                DataNascita = DateOnly.ParseExact("02/09/1919", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Geoffrey",
                Cognome = "Porter",
                Telefono = "0994 372 9709",
                Email = "donec@aol.com",
                DataNascita = DateOnly.ParseExact("28/12/1911", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Hall",
                Cognome = "Goff",
                Telefono = "0800 1111",
                Email = "lacus.ut@icloud.ca",
                DataNascita = DateOnly.ParseExact("15/07/1913", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Adrienne",
                Cognome = "Barlow",
                Telefono = "0845 46 47",
                Email = "hendrerit@aol.ca",
                DataNascita = DateOnly.ParseExact("19/08/1948", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Lester",
                Cognome = "Russo",
                Telefono = "07681 312426",
                Email = "ipsum@outlook.edu",
                DataNascita = DateOnly.ParseExact("06/01/1978", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Flavia",
                Cognome = "Perez",
                Telefono = "0374 046 0366",
                Email = "ut.quam@outlook.org",
                DataNascita = DateOnly.ParseExact("06/10/1948", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Candice",
                Cognome = "Simmons",
                Telefono = "0845 46 44",
                Email = "velit.dui@icloud.ca",
                DataNascita = DateOnly.ParseExact("17/03/2001", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Jason",
                Cognome = "Fischer",
                Telefono = "0800 1111",
                Email = "nascetur.ridiculus.mus@aol.edu",
                DataNascita = DateOnly.ParseExact("07/09/1968", "dd/MM/yyyy", null)
            },
            new Contatto {
                Nome = "Ignatius",
                Cognome = "Buckley",
                Telefono = "0862 284 2385",
                Email = "congue.turpis.in@hotmail.net",
                DataNascita = DateOnly.ParseExact("12/07/1996", "dd/MM/yyyy", null)
            }
        };
    }
}