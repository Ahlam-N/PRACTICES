using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Student
    {
        public int id { get; set; }
        public string name { set; get; }
        public int age { set; get; }
        public Grade grade { set; get; }

    }
}
