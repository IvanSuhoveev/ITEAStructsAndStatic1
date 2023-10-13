using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEAStructAndStaticHW
{
    public struct LibraryCard
    {
        DateTime _timeeRegistration;
        string _nameReader;
        string _cardNum;
        public DateTime RegistationDate { get { return _timeeRegistration; } }
        public string ReaderName { get { return _nameReader; } }
        public string CardNum { get { return _cardNum; } }

        public LibraryCard(DateTime time,string nameReader,string cardNum)
        {
            _timeeRegistration= time;
            _nameReader = nameReader;
            _cardNum = cardNum;
        }
    }
}
