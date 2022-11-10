namespace Sleep_Safety_Reading.Models
{
    public class User
    {
        public int userId { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public ICollection<Sleep> sleeps { get; set; }
        public ICollection<Library> libraries { get; set; }
        public User()
        {
            libraries = new List<Library>();
            sleeps = new List<Sleep>();
        }
        public int addSleep(Sleep sleep)
        {
            if (sleep != null)
            {
                sleeps.Add(sleep);
                return 1;
            }
            else 
            { 
                return -1; 
            }
        }
        public int addLibrary(Library library)
        {
            if (library != null)
            {
                libraries.Add(library);
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int deleteSleep(Sleep sleep)
        {
            if (sleep != null)
            {
                sleeps.Remove(sleep);
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int deleteLibrary(Library library)
        {
            if (library != null)
            {
                libraries.Add(library);
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int getStatistics()
        {
            if (sleeps.Count > 0)
            {
                // to do: get statistics code
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int getRecomendations()
        {
            if (this.getStatistics() == 1)
            {
                // to do: form recomendations that depends on statistic code
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
