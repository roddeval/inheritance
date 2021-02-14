using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public class Part
    {

        private int _Year;
        private string _Make;
        private string _Model;
        private string _Name;

        public Part()
        {
            Initialize();
        }

        public Part(int year, string make, string model, string name)
        {
            Initialize();
            Year = year;
            Make = make;
            Model = model;
            Name = name;
        }

        public Part(Part part)
        {
            Initialize();
            if (part != null)
            {
                Year = part.Year;
                Make = part.Make;
                Model = part.Model;
                Name = part.Name;
            }
        }

        public virtual void Initialize()
        {
            Year = 0;
            Make = "";
            Model = "";
            Name = "";
        }

        public virtual string FormatDisplayString()
        {
            StringBuilder stringBuilder = null;
            string result = "";

            try
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Part.FormatDisplayString\r\n");
                stringBuilder.Append(string.Format(" Year: {0}\r\n", Year));
                stringBuilder.Append(string.Format(" Make: {0}\r\n", Make));
                stringBuilder.Append(string.Format("Model: {0}\r\n", Model));
                stringBuilder.Append(string.Format(" Name: {0}\r\n", Name));
                stringBuilder.Append("----------\r\n");
                result = stringBuilder.ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }

        public int Year
        {
            set
            {
                _Year = value;
            }
            get
            {
                return _Year;
            }

        }
        public string Make
        {
            set
            {
                _Make = value;
            }
            get
            {
                return _Make;
            }

        }
        public string Model
        {
            set
            {
                _Model = value;
            }
            get
            {
                return _Model;
            }

        }
        public string Name
        {
            set
            {
                _Name = value;
            }

            get
            {
                return _Name;
            }
        }
    }

}
