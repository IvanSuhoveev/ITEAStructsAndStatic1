using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEAStructAndStaticHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book book = new Book("Властелин колец", "1954", "Джон Р. Р. Толкин", "фэнтези");
            books.Add(book);
            books.Add(book);
           Book book1 = new Book("Автостопом по галактике", "1979", "Дуглас Адамс", "фантастика");
            books.Add(book1);
            books.Add(book1);
            books.Add(book1);
            books.Add(book1);
           Book book2 = new Book("Психология народов и масс", "2020","Лебон", "историческая литература");
            books.Add(book2);
           Book book3 = new Book("Ярость","1977","Стивен Кинг","фантастика");
            books.Add(book3);
           Book book4 = new Book("Самые мудрые притчи и афоризмы", "2020","Омар Хаям", "поэзия");
            books.Add(book4);
            books.Add(book4);
           Book book5 = new Book("Смерть и круассаны", "2023", "Мур Йен", "детектив");
            books.Add(book5);
            books.Add(book5);
            books.Add(book5);

          List<LibraryCard> libraryCards = new List<LibraryCard>();

            LibraryCard card = new LibraryCard(new DateTime(1945, 5, 8),"Иван Иванов","01");
            libraryCards.Add(card);
            LibraryCard card2 = new LibraryCard(new DateTime(2022, 4, 5),"Сергей Сидоров","02");
            libraryCards.Add(card2);
            LibraryCard card3 = new LibraryCard(new DateTime(2001, 12, 01),"Александр Фролов","03");
            libraryCards.Add(card3);
            LibraryCard card4 = new LibraryCard(new DateTime(2010, 10, 13),"Богдан Филипенко","04");
            libraryCards.Add(card4);
            LibraryCard card5 = new LibraryCard(new DateTime(2015, 1, 11),"Андрей Григорьев","05");
            libraryCards.Add(card5);
            LibraryCard card6 = new LibraryCard(new DateTime(2013, 2, 10),"Светлана Васильевна","06");
            libraryCards.Add(card6);

            Library lib=new Library(books,libraryCards);

            Console.WriteLine("=======================================================================");
            lib.TakeBook("Властелин колец", "01", new DateTime(2023, 05, 20), 30);
            Console.WriteLine("=======================================================================");
            lib.TakeBook(book,card6, new DateTime(2023, 07, 14), 25);
            Console.WriteLine("=======================================================================");
            lib.TakeBook("Ярость", "02", new DateTime(2023, 08, 01), 15);
            Console.WriteLine("=======================================================================");
            lib.TakeBook("Автостопом по галактике", "04", new DateTime(2023, 08, 01), 22);

            Console.WriteLine("=======================================================================");
            lib.ReturnBook("Властелин колец", "01");
            Console.WriteLine("=======================================================================");
            lib.ReturnBook(book, card6);
            Console.WriteLine("=======================================================================");
            lib.ReturnBook("Ярость", "02");
            Console.WriteLine("=======================================================================");
            lib.ReturnBook(book1.Name,card4.CardNum);
            Console.ReadKey();
        }
      
    }
}
