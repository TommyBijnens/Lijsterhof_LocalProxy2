using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public static class DB
    {

        public static IEnumerable<ExportParameter> GetList()
        {
            IEnumerable<Parameters> parametersTable;
            using (var db = new CVLoggerEntities())
            {
                parametersTable = db.Parameters.ToList();
            }

            return parametersTable.Select(p => p.ToDBParameter().ForExport());
        }

        public static ExportParameter GetParameter(string key)
        {
            using (var db = new CVLoggerEntities())
            {
                return db.Parameters.FirstOrDefault(p => p.key == key)?.ToDBParameter().ForExport();
            }
        }

        public static ExportParameter SetParameter(string key, float value)
        {
            Parameters selectedParameter;
            using (var db = new CVLoggerEntities())
            {
                selectedParameter = db.Parameters.FirstOrDefault(p => p.key == key);
                selectedParameter.value = value;
            }

            return selectedParameter.ToDBParameter().ForExport();
        }



        private static DBParameter ToDBParameter(this Parameters p)
        {
                return new DBParameter()
                {
                    key = p.key,
                    Value = p.value,
                };
            
        }


    }
}