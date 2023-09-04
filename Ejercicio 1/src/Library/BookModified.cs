using System;

namespace Ucu.Poo.Expert
{
    public class BookIdentity
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public BookIdentity(String title, String author, String code)
        {
            this.Title = title;                                
            this.Author = author;
            this.Code = code;
        }

    /* Esta clase se encarga exclusivamente a asignarle al libro que libro es, es decir, su nombre, autor y codigo */

    }
}
