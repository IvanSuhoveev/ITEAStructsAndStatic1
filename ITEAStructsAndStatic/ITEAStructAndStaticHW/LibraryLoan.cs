using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEAStructAndStaticHW
{
    public struct LibraryLoan
    {
        DateTime _takenTime, _returnTime;
        Book _takenbook;
        LibraryCard _card;
       public Book takenBook { get { return _takenbook; } }
        public LibraryCard Card { get { return _card; } }
        public DateTime takenTime { get { return _takenTime; } }
        public DateTime returnTime { get { return _returnTime; } }


        public LibraryLoan(Book book,LibraryCard card,DateTime takenTime,DateTime returnTime)
        {
            _takenTime = takenTime;
            _returnTime = returnTime;
            _takenbook= book;
            _card= card;
        }
    }
}
