using System.Collections.Generic;

namespace web_theater.Models
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Food> Menu { get; set; }


        // public void addMovie(Movie movie)
        // {
        //     Movies.Add(movie);
        // }
        // public void addFood(Food food)
        // {
        //     Menu.Add(food);
        // }

        // public Theater(string name)
        // {
        //     Name = name;
        // }
    }
}