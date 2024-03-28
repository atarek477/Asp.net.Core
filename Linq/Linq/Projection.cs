using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Projection
    {
        //select 
        //select many
        //zip


      static  List<string> fields = new () { "here", "we", "are" };


        IEnumerable<string> method = fields.Select(x => x.ToUpper());

        IEnumerable<string> query= from x in fields
                                   select x.ToUpper();


    }
}
