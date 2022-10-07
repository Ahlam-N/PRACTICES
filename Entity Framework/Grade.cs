using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Grade
    {
        public int gradeid { set; get; }
        public string gradename { set; get; }
        public ICollection<Student> students { set; get; }

    }
}
