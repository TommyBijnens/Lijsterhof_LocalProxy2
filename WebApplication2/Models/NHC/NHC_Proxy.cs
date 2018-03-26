using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public static class NHC_Proxy
    {
        private static IEnumerable<NHCParameter> parameters;
        private static DateTime lastUpdate;
        private static int timeOut = 5000;  //Time-out in milliseconds
        private static bool IsTimedOut()
        {
            if (lastUpdate.AddMilliseconds(timeOut) < DateTime.Now)
            { 
                lastUpdate = DateTime.Now;
                return true;
            }
            return false;
        }

        public static IEnumerable<ExportParameter> GetList()
        {
            Refresh();
            return parameters.Select(p => p.ForExport());
        }


        //public static ExportParameter GetParameter(string name)
        //{
        //    Refresh();
        //    NHCParameter result = parameters.FirstOrDefault(p => p.description == name);
        //    return result.ForExport();
        //}

        public static ExportParameter GetParameter(string key)
        {
            int id = Int32.Parse(key);
            Refresh();
            NHCParameter result = parameters.FirstOrDefault(p => p.id == id);
            return result.ForExport();
        }

        private static void Refresh()
        {
            if (IsTimedOut())
                {
                string response = NHC.Actions();
                NHCResponse r = JsonConvert.DeserializeObject<NHCResponse>(response);
                parameters = r.data;
            }
        }


        public class NHCResponse
        {
            public IEnumerable<NHCParameter> data { get; set; }
        }



    }


}