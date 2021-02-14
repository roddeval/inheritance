using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS539_inheritance_discussion_code
{
    public class Transmission : Part
    {

        private Boolean _Automatic;
        private Boolean _Manual;

        public Transmission()
        {
            Initialize();
        }
        public Transmission(int year, string make, string model, string name,Boolean automatic, Boolean manual) : base(year,make,model,name)
        {
            Initialize();
            Automatic = automatic;
            Manual = manual;
        }
        public Transmission(Transmission transmission): base(transmission.Year,transmission.Make,transmission.Model, transmission.Name)
        {
            Initialize();
            if (transmission != null)
            {
                Automatic = transmission.Automatic;
                Manual = transmission.Manual;
            }
        }

        public override void Initialize()
        {
            base.Initialize();
            Automatic = false;
            Manual = false;
        }

        public override string FormatDisplayString()
        {
            StringBuilder stringBuilder = null;
            string result = "";

            try
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Transmission.FormatDisplayString\r\n");
                stringBuilder.Append(string.Format("     Year: {0}\r\n", Year));
                stringBuilder.Append(string.Format("     Make: {0}\r\n", Make));
                stringBuilder.Append(string.Format("    Model: {0}\r\n", Model));
                stringBuilder.Append(string.Format("     Name: {0}\r\n", Name));
                stringBuilder.Append(string.Format("Automatic: {0}\r\n", Automatic));
                stringBuilder.Append(string.Format("   Manual: {0}\r\n", Manual));
                stringBuilder.Append("----------\r\n");
                result = stringBuilder.ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return result;
        }


        public Boolean Automatic
        {
            set
            {
                _Automatic = value;
            }
            get
            {
                return _Automatic;
            }
        }
        public Boolean Manual
        {
            set
            {
                _Manual = value;
            }
            get
            {
                return _Manual;
            }
        }
    }
}
