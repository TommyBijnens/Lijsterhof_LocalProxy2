using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using WebApplication2.Models.General;

namespace WebApplication2.Models
{
    public static class CV
    {

        //private static string name = "Central heating system";
        private static Dictionary<string, CVParameter> parameterList = CVParameterService.parameterDictionary();

        public static IEnumerable<ExportParameter> GetList()
        {
            List<CVParameter> result = new List<CVParameter>();
            foreach (var item in parameterList)
            {
                CVParameter p = item.Value;
                p.key = item.Key;
                result.Add(p);
            }
            return result.Select(p => p.ForExport());
        }

        public static ExportParameter GetParameter(string key)
        {
        if (parameterList.TryGetValue(key, out CVParameter result))
            {
                result.key = key;
                string logoAddress = ConfigurationManager.AppSettings["LogoAddress"];
                string response = WebService.getFromWebService(logoAddress + result.device + "/attributes/" + result.attribute+ "/value");
                result.Value  = float.Parse(response.Replace(".", ","));
                return result.ForExport();
            }
        else
            {
                return null;
            }

        }

        public static CVParameter SetParameter(string key, float value)
        {

            if (parameterList.TryGetValue(key, out CVParameter result) && result.IsValidFor(value))
            {
                result.key = key;
                string logoAddress = ConfigurationManager.AppSettings["LogoAddress"];
                string response = WebService.getFromWebService(logoAddress + result.device + "/attributes/" + result.attribute + "/value?set="+value);
                result.Value = float.Parse(response.Replace(".", ","));
                return result;
            }
            else
            {
                return null;
            }

        }
    






    }




}