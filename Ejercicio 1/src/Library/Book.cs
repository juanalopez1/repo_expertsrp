using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;                                
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        /* Considero que esta clase no cumple con srp ya que no solo asigna la informacion general del libro como el nombre, autor y codigo del
        mismo, sino que tambien el sector y estante en donde debe estar ubicado. De la misma manera, expert tampoco se
        cumple ya que la clase Book no sabe información respecto a la biblioteca donde los libros estarán ubicados. */

    }
}
