using System.Collections.Generic;

namespace web_theater.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // public Dictionary<string, Ticket> Showtimes = new Dictionary<string, Ticket>();

        // public void addShowtime(string time, float cost, int inventory)
        // {
        //     Showtimes.Add(time, new Ticket(this, time, cost, inventory));
        // }
        // public Movie(string title, string description)
        // {
        //     Title = title;
        //     Description = description;
        // }


    }
}