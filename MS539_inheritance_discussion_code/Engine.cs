using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public class Engine : Part
    {
        private int _Cylinder;
        public Engine()
        {
            Initialize();
        }
        public Engine(int year, string make, string model, string name, int cylinder) : base(year, make, model, name)
        {
            Initialize();
            Cylinder = cylinder;
        }
        public Engine(Engine engine): base(engine.Year,engine.Make,engine.Model,engine.Name)
        {
            Initialize();
            if (engine != null)
            {
                Cylinder = engine.Cylinder;
            }
        }

        public override void Initialize()
        {
            Cylinder = 0;

        }

        public override string FormatDisplayString()
        {
            StringBuilder stringBuilder = null;
            string result = "";

            try
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Engine.FormatDisplayString\r\n");
                stringBuilder.Append(string.Format("    Year: {0}\r\n", Year));
                stringBuilder.Append(string.Format("    Make: {0}\r\n", Make));
                stringBuilder.Append(string.Format("   Model: {0}\r\n", Model));
                stringBuilder.Append(string.Format("   Name: {0}\r\n", Name));
                stringBuilder.Append(string.Format("Cylinder: {0}\r\n", Cylinder));
                stringBuilder.Append("----------\r\n");
                result = stringBuilder.ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }


        public int Cylinder
        {
            set
            {
                _Cylinder = value;
            }
            get
            {
                return _Cylinder;
            }
        }

    }
}
