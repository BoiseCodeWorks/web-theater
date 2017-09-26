using System.Collections.Generic;

namespace web_theater.Models
{
    public class Movie
    {
        public string Title;
        public string Description;
        public Dictionary<string, Ticket> Showtimes = new Dictionary<string, Ticket>();

        public void addShowtime(string time, float cost, int inventory)
        {
            Showtimes.Add(time, new Ticket(this, time, cost, inventory));
        }
        public Movie(string title, string description)
        {
            Title = title;
            Description = description;
        }


    }
}