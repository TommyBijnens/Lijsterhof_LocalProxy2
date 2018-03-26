using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2.Models
{
    [Serializable]
    public class NHCParameter: Parameter
    {
        public string name
        {
            get { return description; }
            set { description = value; }
        }
        public int device;
        public int attribute;
        public int type { get; set; }
        public int location { get; set; }
        public int id
        { get {return Int32.Parse(key); }
            set { key = value.ToString(); }
        }
        public float? value1
        {
            get { return Value; }
            set { Value = value; }
        }



        public NHCParameter(string _description, int _device, int _attribute, bool _canWrite = true)
        {
            description = _description;
            device = _device;
            attribute = _attribute;
            canWrite = _canWrite;

        }

        public override string GetTypeDescription()
        {
            return type.ToString();
        }
    }
}