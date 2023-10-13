using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITEAStructAndStaticHW
{
    public struct Library
    {
        List<Book> _books;
        List<LibraryCard> _cards;
        List<LibraryLoan> _loans;

        public Library(List<Book> books, List<LibraryCard> cards)
        {
            _books = books;
            _cards = cards;
            _loans = new List<LibraryLoan>();

        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void AddCard(LibraryCard card)
        {
            if (!_cards.Contains(card))
                _cards.Add(card);
        }

        public void TakeBook(LibraryLoan loan)
        {
            _loans.Add(loan);
            Console.WriteLine($"{loan.Card.ReaderName} взял книгу {loan.takenBook.Name}, дата видачи {loan.takenTime}, дата возвращения {loan.returnTime}");
        }
        public void TakeBook(Book book, LibraryCard card, DateTime takenTime, int days)
        {
            DateTime returnTime = new DateTime(takenTime.Year, takenTime.Month, takenTime.Day, 18, 0, 0);
          returnTime=returnTime.AddDays(days);
            while (returnTime.DayOfWeek == DayOfWeek.Sunday || returnTime.DayOfWeek == DayOfWeek.Saturday)
            {
               returnTime= returnTime.AddDays(1);
            }
            LibraryLoan loan = new LibraryLoan(book, card, takenTime, returnTime);
            _loans.Add(loan);
            _books.Remove(book);

            Console.WriteLine($"{loan.Card.ReaderName} взял книгу {loan.takenBook.Name}, дата видачи {loan.takenTime}, дата возвращения {loan.returnTime}");
        }
        public void TakeBook(string bookName, string num, DateTime takenTime, int days)
        {
            Book book = new Book();
            foreach (var _book in _books)
            {
                if (_book.Name == bookName)
                {
                    book = _book; break;
                }
            }
            DateTime returnTime = new DateTime(takenTime.Year,takenTime.Month,takenTime.Day,18,0,0);
           returnTime= returnTime.AddDays(days);
            while (returnTime.DayOfWeek == DayOfWeek.Sunday || returnTime.DayOfWeek == DayOfWeek.Saturday)
            {
               returnTime= returnTime.AddDays(1);
            }
            LibraryCard libraryCard = takeCard(num);

            LibraryLoan loan = new LibraryLoan(book, libraryCard, takenTime, returnTime);
            _loans.Add(loan);
            _books.Remove(book);
            Console.WriteLine($"{loan.Card.ReaderName} взял книгу {loan.takenBook.Name}, дата видачи {loan.takenTime}, дата возвращения {loan.returnTime}");
        }

        public LibraryCard takeCard(string numcard)
        {
            foreach (var card in _cards)
            {
                if (card.CardNum == numcard)
                {
                    return card;

                }
            }
            return new LibraryCard();
        }
        LibraryLoan takeLoan(LibraryCard card, Book book)
        {
            foreach (var loan in _loans) {
                if(loan.Card.Equals(card)&&loan.takenBook.Equals(book))
                return loan;
             }
            return new LibraryLoan();
        }
       LibraryLoan takeLoan(string Cardnum,string bookName)
        {
            foreach (LibraryLoan _loan in _loans)
            {
                if (_loan.Card.CardNum == Cardnum && _loan.takenBook.Name == bookName)
                {
                    return _loan;
                }
            }
            return new LibraryLoan();
           
        }
       public void ReturnBook(LibraryLoan loan)
        {
            double lating = lateCheck(loan.returnTime);
            if (lating > 0)
            {
                Console.WriteLine($"Опаздание на {(int)lating} дней!");
            }
            else
            {
                Console.WriteLine("Опазданий нет");
            }
            _books.Add(loan.takenBook);
            _loans.Remove(loan);
            Console.WriteLine($"{loan.Card.ReaderName} успешно сдал книгу {loan.takenBook.Name}");
        }
        public void ReturnBook(string bookName,string numCard) 
        {
            LibraryCard card = takeCard(numCard);
            LibraryLoan loan = takeLoan(numCard,bookName);
           
            double lating = lateCheck(loan.returnTime);
            if (lating > 0)
            {
                Console.WriteLine($"Опаздание на {(int)lating} дней!");
            }
            else
            {
                Console.WriteLine("Опазданий нет");
            }
            _books.Add(loan.takenBook);
            _loans.Remove(loan);
            Console.WriteLine($"{loan.Card.ReaderName} успешно сдал книгу {loan.takenBook.Name}");
        }

        public void ReturnBook(Book book,LibraryCard Card)
        {
           
            LibraryLoan loan = takeLoan(Card,book);
       
            double lating = lateCheck(loan.returnTime);
            if (lating> 0)
            {
                Console.WriteLine($"Опаздание на {(int)lating} дней!");
            }
            else
            {
                Console.WriteLine("Опазданий нет");
            }
            _books.Add(loan.takenBook);
            _loans.Remove(loan);
            Console.WriteLine($"{loan.Card.ReaderName} успешно сдал книгу {loan.takenBook.Name}");
        }
        double lateCheck(DateTime time)
        {
            return (DateTime.Now-time).TotalDays;
        }

    }
}
