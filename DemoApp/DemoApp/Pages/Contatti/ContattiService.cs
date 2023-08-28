namespace DemoApp.Pages.Contatti
{
    public class ContattiService: IContattiService
    {
        public ContattiService(string connectionString)
        {
            
        }

        public IList<Contatto> GetContatti() 
        {
            throw new NotImplementedException();
        }

        public Contatto GetContatto(int id) 
        {
            throw new NotImplementedException();
        }

        public IList<Contatto> Search(string searchText) 
        {
            throw new NotImplementedException();
        }

        public int GetContattiCount() 
        {
            throw new NotImplementedException();
        }

        public Contatto Add(Contatto contatto)
        {
            throw new NotImplementedException();
        }

        public Contatto Aggiorna(Contatto contatto)
        {
            throw new NotImplementedException();
        }
    }
}
