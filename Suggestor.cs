﻿namespace MovieRent
{
    public interface ISuggester
    {
        List<Movie> SuggestByGenre(string genre);
    }

    public class Suggester: ISuggester
    {
        private List<Movie> movies;

        public Suggester(List<Movie> movies)
        {
            this.movies = movies;
        }

        public List<Movie> SuggestByGenre(string genre)
        {
            return movies.Where(m => m.Genre == genre).ToList();
        }
    }
}