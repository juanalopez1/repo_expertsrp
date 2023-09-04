using System;

namespace Ucu.Poo.Expert
{
    public class ShelveBook
    {

        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        

        public ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        public String Ubication(BookIdentity book)
        {
            return LibrarySector + LibraryShelve;
        }

        /* Esta clase es la encargada de repartir los libros en su 
        debida ubicacion de la biblioteca, lo que vendria a ser su respectivo sector y estante */

    }
}
