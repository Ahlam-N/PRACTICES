using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Class1
    {


        List<student> querysyntax = (from obj in student.getallstudent()
                                    where obj.Name == "Ahlam"
                                    select obj).ToList();
        foreach(var item in querysynatax){
           
            }
    }
}
