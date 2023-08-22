namespace DemoApp.Pages.Contatti
{
    public interface IContattiService
    {
        IList<Contatto> GetContatti();
        int GetContattiCount();
        Contatto GetContatto(int id);
        IList<Contatto> Search(string searchText);
    }
}
