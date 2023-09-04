using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            BookIdentity book1 = new BookIdentity("Design Patterns ","Erich Gamma & Others ","001-034");
            BookIdentity book2 = new BookIdentity("Pro C# ","Troelsen ","001-035");
            ShelveBook ubication1 = new ShelveBook("A", "7"); 
            ShelveBook ubication2 = new ShelveBook("B", "8"); 
            
        }
    }
}