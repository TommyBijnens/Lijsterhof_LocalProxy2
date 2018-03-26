using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2.Models
{
    [Serializable]
    public class Parameter
    {
        public string key;
        public string description;
        public float? Value { get; set; }
        public bool canWrite;
        public DisplayType displayType;

        public virtual string GetTypeDescription()
        {
            return "unknown";
        }

        public ExportParameter ForExport()
        {
            var result =  new ExportParameter()
            {
                key = this.key,
                description = this.description,
                Value = this.Value,
                type = this.GetTypeDescription(),
                canWrite = this.canWrite,
                displayType = this.displayType
            };
            if (this.GetType() == typeof(DBParameter))
                {
                result.canWrite = true;
                result.displayType = DisplayType.Numericbox;
                result.description = key.Replace("_", " ").Replace("temp", "Temperatuur ").Replace("  ", " ");
 
                }
            if (this.GetType() == typeof(NHCParameter))
            {

                NHCParameter thisParameter = (NHCParameter)this;
                if (thisParameter.type == 1) result.displayType = DisplayType.Switch;
                if (thisParameter.type == 2) result.displayType = DisplayType.Numericbox;
            }

            if (this.GetType() == typeof(CVParameter))
            {
            }


            return result;
        }

        public bool IsValidFor(float input)
        {
            bool validation = true;
            if (this.canWrite == false) validation = false;
            if (this.displayType == DisplayType.Switch)
            {
                if ((input != 1) && (input != 0)) validation = false;
            }

            return validation;
        }



        public enum DisplayType
        {
            None,
            Switch,
            Slider,
            Textbox,
            Numericbox,
            Gauge,
            Pump
        };
    }
}