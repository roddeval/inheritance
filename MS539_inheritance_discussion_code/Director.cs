using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public class Director
    {

        public bool Construct(Builder builder,string[] parameters)
        {
            bool result = builder.Construct(parameters);
            return result;
        }

    }
}
