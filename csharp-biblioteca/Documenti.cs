using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documenti
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Sector { get; set; }
        public string Scaffale { get; set; }
        public string Author { get; set; }

        public Documenti() 
        {
            Title = string.Empty;
            Year = 0;
            Sector = string.Empty;
            Scaffale = string.Empty;
            Author = string.Empty;
        }

        public Documenti(string title, int year, string sector, string scaffale, string author)
        {
            Title = title;
            Year = year;
            Sector = sector;
            Scaffale = scaffale;
            Author = author;
        }

        public void CreateCode()
        {
            System.Random rng = new();
            int Codice = rng.Next(1000, 9999);
            Console.WriteLine($"Code: {Codice}");
        }

        public virtual void ListDvdBooks()
        {
            Console.WriteLine($"Scegli cosa prendere in prestito:");
            Console.WriteLine(Title);
        }
        public override string ToString()
        {
            return $"Titolo: {Title}";
        }
    }

    public class DVD : Documenti
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Sector { get; set; }
        public string Scaffale { get; set; }
        public string Author { get; set; }
        public int Durata { get; set; }

        public DVD(string title, int year, string sector, string scaffale, string author, int durataInMinuti) :base(title, year, sector, scaffale, author)
        {
            Durata = durataInMinuti;
        }
    }

    public class Book : Documenti
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Sector { get; set; }
        public string Scaffale { get; set; }
        public string Author { get; set; }
        public int NumbersOfPages { get; set; }

        public Book(string title, int year, string sector, string scaffale, string author, int NumbersOfPages) : base(title, year, sector, scaffale, author)
        {

        }
    }
}
