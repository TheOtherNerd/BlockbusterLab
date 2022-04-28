using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            Movies.Add(new DVD("Saving Private Ryan", 300, Genre.Drauma, "scene1", "scene2", "scene3", "scene4"));
            Movies.Add(new DVD("Lion King", 102, Genre.Drauma, "scene1", "scene2", "scene3", "scene4"));


        }
        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"Index: {i}, {m.Title}");
            }
        }
        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to watch?");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Movie m = Movies[index];
            m.PrintInfo();
            return m;
        }

    }
}
