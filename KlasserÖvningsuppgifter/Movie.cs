using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserÖvningsuppgifter
{
    internal class Movie
    {
        //Properties
        public string Title { get; set; }
        public string Director { get; set; }

        private int _rating;
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0)
                {
                    _rating = 0;
                }
                else if (value > 5)
                {
                    _rating = 5;
                }
                else
                {
                    _rating = value;
                }
            }
        }

        //Konstruktör
        public Movie(string Title, string Director, int Rating)
        {
            this.Title = Title;
            this.Director = Director;
            this.Rating = Rating;
        }
        //Metoder
        public void PrintMovieInfo()
        {
            Console.WriteLine($"Title: {Title}, Director: {Director}, Rating: {Rating}/5");
        }
    }
}
