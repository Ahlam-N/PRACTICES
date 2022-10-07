using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.DbContext;

namespace Entity_Framework
{
   public class StudentContext:DbContext
    {
        public Dbset<Student> Students { get; set; }
        public Dbset<Grade> grades { get; set; }
    }
}
