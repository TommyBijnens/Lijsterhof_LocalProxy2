using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2.Models
{
    [Serializable]
    public class RPIParameter: Parameter
    {
        public string ip;
        

        public RPIParameter(string _description, string _ip, DisplayType _displayType, bool _canWrite = false)
        {
            description = _description;
            ip = _ip;
            canWrite = _canWrite;
            displayType = _displayType;
        }

        public override string GetTypeDescription()
        {
            return "RPI Parameter";
        }
    }
}