
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public interface IPerson
    {
         string FirstName { get; set; }
         string SecondName { get; set; }
        DateTime BirthDate { get; set; }
    }
}
