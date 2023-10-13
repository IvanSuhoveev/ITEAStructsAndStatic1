using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEAStructAndStaticHW
{
    public struct Book
    {
        string _name, _year, _autor, _genre;
            public string Name { get { return _name; } }
            public string Year { get {return _year; } }
            public string Autor { get {return _autor; } }
            public string Genre { get {return _genre; } }
  
        public Book(string name,string year,string autor,string genre)
        {
            _name = name;
            _year = year;
            _autor = autor;
            _genre = genre;
        }
    }
}
