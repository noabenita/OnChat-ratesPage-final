using OnChat.Models;

namespace OnChat.Services
{
    public class RateService : IRateService
    {
        private static List<Rates> rates = new List<Rates>();
        public List<Rates> GetAll()
        {
            return rates;
        }
        public Rates Get(string name)
        {
            return rates.Find(x => x.Name.Equals(name));
        }

        public List<Rates> GetAllByName(string query)
        {
            List<Rates> newRates = new List<Rates>();
            for (var i = 0; i < rates.Count; i++)
            {
                if (query != null)
                {
                    if (rates[i].Name.Contains(query) || rates[i].Feedback.Contains(query) ||
                       rates[i].Date.Contains(query) || rates[i].Time.Contains(query) ||
                       rates[i].Rate.ToString().Contains(query))
                    {
                        newRates.Add(rates[i]);
                    }
                }
            }
            return newRates;
        }

        public void Delete(string name)
        {
            rates.Remove(Get(name));
        }

        public void Edit(int rate, string feedback, string name)
        {
            Rates r = (Get(name));
            r.Feedback = feedback;
            r.Rate = rate;
            r.Time = DateTime.Now.ToString("HH:mm:ss");
            r.Date = DateTime.Today.ToString("dd-MM-yyyy");
        }

        public void Create(int rate, string feedback, string name)
        {
            rates.Add(new Rates()
            {
                Rate = rate,
                Feedback = feedback,
                Name = name,
                Date = DateTime.Today.ToString("dd-MM-yyyy"),
                Time = DateTime.Now.ToString("HH:mm:ss")
            });
        }

    }
}

