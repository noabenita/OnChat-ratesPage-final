using OnChat.Models;

namespace OnChat.Services
{
    public interface IRateService
    {
        public List<Rates> GetAll();

        public Rates Get(string id);

        public void Delete(string name);

        public void Edit(int rate, string feedback, string id);

        public void Create(int rate, string feedback, string name);
        public List<Rates> GetAllByName(string query);

    }
}
