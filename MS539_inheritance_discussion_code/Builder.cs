using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public abstract class Builder
    {

        public abstract bool Construct(string[] parameters);

    }

    public class PartBuilder : Builder
    {

        private const int YEAR = 0;
        private const int MAKE = 1;
        private const int MODEL = 2;
        private const int NAME = 3;

        public Part BuildResult {set;get;}

        public override bool Construct(string[] parameters)
        {
            bool ok = false;
            int y = 0;

            if (parameters != null)
            {
                if (parameters.Length == 4)
                {
                    if (int.TryParse(parameters[YEAR], out y) == true)
                    {
                        BuildResult = new Part(y, parameters[MAKE], parameters[MODEL], parameters[NAME]);
                        if (BuildResult != null)
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            return ok;
        }
    }

    public class EngineBuilder : Builder
    {
        private const int YEAR = 0;
        private const int MAKE = 1;
        private const int MODEL = 2;
        private const int NAME = 3;
        private const int CYLINDER = 4;

        public Engine BuildResult { set; get; }

        public override bool Construct(string[] parameters)
        {
            bool ok = false;
            int y = 0;
            int c = 0;
            if (parameters != null)
            {
                if (parameters.Length == 5)
                {

                    if ((int.TryParse(parameters[YEAR], out y) == true) && 
                        (int.TryParse(parameters[CYLINDER], out c) == true))
                    {
                        BuildResult = new Engine(y, parameters[MAKE], parameters[MODEL], parameters[NAME], c);
                        if (BuildResult != null)
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            return ok;

        }
    }

    public class TransmissionBuilder : Builder
    {

        private const int YEAR = 0;
        private const int MAKE = 1;
        private const int MODEL = 2;
        private const int NAME = 3;
        private const int AUTOMATIC = 4;
        private const int MANUAL = 5;

        public Transmission BuildResult { set; get; }

        public override bool Construct(string[] parameters)
        {
            bool ok = false;
            int y = 0;
            Boolean a = false;
            Boolean m = false;

            if (parameters != null)
            {                
                
                if (parameters.Length == 6)
                {

                    if ((int.TryParse(parameters[YEAR], out y)==true) && 
                        (Boolean.TryParse(parameters[AUTOMATIC], out a) == true) && 
                        (Boolean.TryParse(parameters[MANUAL], out m) == true))
                    {
                        BuildResult = new Transmission(y, parameters[MAKE], parameters[MODEL], parameters[NAME], a, m);
                        if (BuildResult != null)
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                        }
                    }
                }

            }
            return ok;
        }
    }

}
