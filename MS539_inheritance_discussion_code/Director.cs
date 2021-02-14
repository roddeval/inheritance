using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public class Director
    {

        public Part Construct(Builder builder,string[] parameters)
        {
            Part result = null;
            result = builder.BuildPart(parameters);
            return result;
        }

    }
}
