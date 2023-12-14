using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_EXa
{
    internal class Program
    {
        public static void Modificar (List<Book> l, int code , string title) 
        {
            foreach (Book mod in l) 
            {
              if (mod.Code == code) 
                {
                 mod.Title = title;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Book> lisbook = new List<Book>();
            lisbook.Add(new Book {
                Author = "juan",
                Code = 1,
                Cost = 200,
                Title = "maaaaaaa",
                NumPages = 10,
                YearPublic = 2002
            });


            lisbook.Add(new Book
            {
                Author = "Maria",
                Code = 2,
                Cost = 300,
                Title = "moooooooo",
                NumPages = 100,
                YearPublic = 2001
            });

            List<Thesis> tesis = new List<Thesis>();
            tesis.Add(new Thesis {
                Author = "Maria",
                Code = 2,
                Cost = 300,
                Title = "moooooooo",
                CarrerEspeciale = "sis",
                DefeceDate = DateTime.Parse("10/10/2023")
            });
            foreach (Book book in lisbook)
            {
                Console.WriteLine(book.Author + " " + book.Title);
            }

            var order = lisbook.OrderBy(x => x.YearPublic);
            foreach (Book list in order)
            {
                Console.WriteLine(list.YearPublic);
            }

            var prom = lisbook.Average(x =>x.Cost);
            Console.WriteLine(prom);

            Modificar(lisbook,1,"rrrrrrr");
            foreach (Book item in lisbook)
            {
                Console.WriteLine(item.Author+item.Title);
            }
            //lisbook.Clear();

            foreach (Thesis item in tesis)
            { 
               Console.WriteLine((DateTime.Now-item.DefeceDate).Days);
            }
            Console.ReadKey(); 
            
        }
    }
}
