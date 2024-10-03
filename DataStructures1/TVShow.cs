using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataStructures1.Program;

namespace DataStructures1
{
    internal class TVShow
    {
        public string title = "Untitled";
        public int releaseYear;
        public double price;
        public MovieRating rating;

        public TVShow(string title, int releaseYear, double price ,MovieRating rating)
        {
            this.title = title;
            this.releaseYear = releaseYear;
            this.price = price;
            this.rating = rating;
        }

        public override string ToString()
        {
            return title + " (" + releaseYear + ") Rated" + rating + "...£" + price.ToString("0.00");
        }
    }
}
