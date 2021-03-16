using System;
using System.Collections.Generic;
using System.Text;

namespace bmdb_console {
    class Movie {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Rating { get; set; }
        public int Year { get; set; }
        public String Director { get; set; }


        public Movie() {

        }

        public Movie(int Id, String Title, String Rating, int Year, String Director) {
            this.Id = Id;
            this.Title = Title;
            this.Rating = Rating;
            this.Year = Year;
            this.Director = Director;

        }





        public override string ToString() {
            return $"Movie: {Id}, {Title}, {Rating}, {Year}, {Director}";
        }
    }
}
