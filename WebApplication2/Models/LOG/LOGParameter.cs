using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class LOGParameter
    {
        public List<LOGValue> values;

        public LOGParameter()
        {
            values = new List<LOGValue>();
        }


        public void addValue(DateTime t, float? v)
        {
            values.Add(new LOGValue() { time = t, value = v });
        }

    }



    public class LOGValue
    {
        public DateTime? time;
        public float? value;
    }

}


