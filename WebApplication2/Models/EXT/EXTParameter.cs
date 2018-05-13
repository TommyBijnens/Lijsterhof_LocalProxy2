using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2.Models
{
    [Serializable]
    public class EXTParameter: Parameter
    {
        public int device;
        public int attribute;

        public string url;
        

        public EXTParameter(string _description, string _url, DisplayType _displayType, bool _canWrite = false)
        {
            description = _description;
            url = _url;
            canWrite = _canWrite;
            displayType = _displayType;
        }

        public override string GetTypeDescription()
        {
            return "EXT Parameter";
        }
    }
}