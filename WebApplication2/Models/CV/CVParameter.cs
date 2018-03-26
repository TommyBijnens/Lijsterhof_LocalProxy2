using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2.Models
{
    [Serializable]
    public class CVParameter: Parameter
    {
        public int device;
        public int attribute;
        

        public CVParameter(string _description, int _device, int _attribute, DisplayType _displayType, bool _canWrite = false)
        {
            description = _description;
            device = _device;
            attribute = _attribute;
            canWrite = _canWrite;
            displayType = _displayType;
        }

        public override string GetTypeDescription()
        {
            return "CV Parameter";
        }
    }
}