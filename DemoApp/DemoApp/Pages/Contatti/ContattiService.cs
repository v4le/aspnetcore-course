namespace DemoApp.Pages.Contatti
{
    public class ContattiService
    {
        public IList<Contatto> Contatti { get; } = new List<Contatto>
        {
            new Contatto {
                Id = 1,
                Nome = "Jane",
                Cognome = "Rivera",
                Telefono = "0800 675 5379",
                Email = "quisque.nonummy@hotmail.edu",
                Sesso = Sesso.Femmina,
                Preferito = true
            },
            new Contatto {
                Id = 2,
                Nome = "Katelyn",
                Cognome = "Molina",
                Telefono = "(01603) 426949",
                Email = "arcu.curabitur.ut@google.ca",
                Sesso = Sesso.Femmina,
                Preferito = true
            },
            new Contatto {
                Id = 3,
                Nome = "Geoffrey",
                Cognome = "Porter",
                Telefono = "0994 372 9709",
                Email = "donec@aol.com",
                Sesso = Sesso.Maschio,
                Preferito = true
            },
            new Contatto {
                Id = 4,
                Nome = "Hall",
                Cognome = "Goff",
                Telefono = "0800 1111",
                Email = "lacus.ut@icloud.ca",
                Sesso = Sesso.Maschio,
                Preferito = true
            },
            new Contatto {
                Id = 5,
                Nome = "Adrienne",
                Cognome = "Barlow",
                Telefono = "0845 46 47",
                Email = "hendrerit@aol.ca",
                Sesso = Sesso.Femmina,
                Preferito = true
            },
            new Contatto {
                Id = 6,
                Nome = "Lester",
                Cognome = "Russo",
                Telefono = "07681 312426",
                Email = "ipsum@outlook.edu",
                Sesso = Sesso.Maschio,
                Preferito = false
            },
            new Contatto {
                Id = 7,
                Nome = "Flavia",
                Cognome = "Perez",
                Telefono = "0374 046 0366",
                Email = "ut.quam@outlook.org",
                Sesso = Sesso.Femmina,
                Preferito = false
            },
            new Contatto {
                Id =8,
                Nome = "Candice",
                Cognome = "Simmons",
                Telefono = "0845 46 44",
                Email = "velit.dui@icloud.ca",
                Sesso = Sesso.Femmina,
                Preferito = false
            },
            new Contatto {
                Id = 9,
                Nome = "Jason",
                Cognome = "Fischer",
                Telefono = "0800 1111",
                Email = "nascetur.ridiculus.mus@aol.edu",
                Sesso = Sesso.Maschio,
                Preferito = false
            },
            new Contatto {
                Id = 10,
                Nome = "Ignatius",
                Cognome = "Buckley",
                Telefono = "0862 284 2385",
                Email = "congue.turpis.in@hotmail.net",
                Sesso = Sesso.Maschio,
                Preferito = false
            }
        };

        public IList<Contatto> GetContatti() 
        {
            return Contatti;
        }

        public Contatto GetContatto(int id) 
        {
            return Contatti.Single(x => x.Id == id);
        }

        public IList<Contatto> Search(string searchText) 
        {
            return Contatti.Where(c =>
                c.Nome.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                c.Cognome.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public int GetContattiCount() 
        {
            return Contatti.Count();
        }
    }
}
