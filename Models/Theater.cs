using System.Collections.Generic;

namespace web_theater.Models
{
    public class Theater
    {
        public string Name;
        public List<Movie> Movies = new List<Movie>();
        public List<Food> Menu = new List<Food>();


    public void addMovie(Movie movie)
    {
        Movies.Add(movie);
    } 
    public void addFood(Food food)
    {
        Menu.Add(food);
    }

    public Theater(string name)
    {
        Name = name;
    }
    }
}