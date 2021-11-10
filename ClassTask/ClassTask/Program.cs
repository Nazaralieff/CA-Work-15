using System;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        enum Genre
        {
            Action,
            Horror,
            Dram,
            Comedy,
            Romantic,
            Biography
        }
    }

    class Ticket
    {
        public Movie movie { get; set; }
        public int duration { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan time { get; set; } // Bu bilmirem nedi ? :/
        public Price price { get; set; }
        public SellTicket sell { get; set; }
        public string genre { get; set; } // Enum-dan gelecek
        public Poster poster { get; set; }
    }

    class Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public double IMDB { get; set; }
        public string[] Cast { get; set; }

    }

    class Poster
    {
        public int PosterWidth;
        public int PublicHeigth;
        public string PosterLocation;
    }

    class SellTicket
    {
        public DateTime sellDate { get; set; }
        public int SellCount { get; set; }
        public int TotalDayIncome { get; set; }
        public int TotalIncome { get; set; }
    }
    class Price
    {
        public int WeeklyPrice;
        public int WeekEndPrice;
    }
}
