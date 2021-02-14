using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public abstract class Builder
    {

        public abstract Part Construct(string[] parameters);

    }

    public class PartBuilder : Builder
    {

        private const int YEAR = 0;
        private const int MAKE = 1;
        private const int MODEL = 2;
        private const int NAME = 3;

        public override Part Construct(string[] parameters)
        {
            Part part = null;
            int y = 0;

            if (parameters != null)
            {
                if (parameters.Length == 4)
                {
                    if (int.TryParse(parameters[YEAR], out y) == true)
                    {
                        part = new Part(y, parameters[MAKE], parameters[MODEL], parameters[NAME]);
                    }
                }

            }
            return part;
        }
    }

    public class EngineBuilder : Builder
    {
        private const int YEAR = 0;
        private const int MAKE = 1;
        private const int MODEL = 2;
        private const int NAME = 3;
        private const int CYLINDER = 4;

        public override Part Construct(string[] parameters)
        {
            Engine engine = null;
            int y = 0;
            int c = 0;
            if (parameters != null)
            {
                if (parameters.Length == 6)
                {

                    if ((int.TryParse(parameters[YEAR], out y) == true) && 
                        (int.TryParse(parameters[CYLINDER], out c) == true))
                    {
                        engine = new Engine(y, parameters[MAKE], parameters[MODEL], parameters[NAME], c);
                    }
                }

            }

            return engine;
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


        public override Part Construct(string[] parameters)
        {
            Transmission transmission = null;
            int y = 0;
            Boolean a = false;
            Boolean m = false;

            if (parameters != null)
            {                
                
                if (parameters.Length == 5)
                {

                    if ((int.TryParse(parameters[YEAR], out y)==true) && 
                        (Boolean.TryParse(parameters[AUTOMATIC], out a) == true) && 
                        (Boolean.TryParse(parameters[MANUAL], out m) == true))
                    {
                        transmission = new Transmission(y, parameters[MAKE], parameters[MODEL], parameters[NAME], a, m);
                    }
                }

            }
            return transmission;
        }
    }

}
