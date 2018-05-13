using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace WebApplication2.Models
{
    public static class DB
    {

        public static IEnumerable<ExportParameter> GetLogs()
        {
            List<Parameters> parametersTable = new List<Parameters>();
            using (var db = new CVLoggerEntities())
            {
                parametersTable = db.GetType()
                    .GetProperties()
                    .Where(p => p.PropertyType.Name.ToLower().Contains("dbset"))
                    .Select(x => new Parameters() { key = x.Name, value = null })
                    .ToList();
            }

            return parametersTable.Select(p => p.ToDBParameter().ForExport());
        }


        public static IEnumerable<ExportParameter> GetParameters()
        {
            IEnumerable<Parameters> parametersTable;
            using (var db = new CVLoggerEntities())
            {
                parametersTable = db.Parameters.ToList();
            }

            return parametersTable.Select(p => p.ToDBParameter().ForExport());
        }

        public static LOGParameter GetLog(string key)
        {
            Interval interval = new Interval() {Days=1, NumberOfItems = 10 };
            LOGParameter logResult = new LOGParameter();

            DateTime? startDate = interval.startTime();

            using (var db = new CVLoggerEntities())
            {
                var result = db.GetType()
                    //.GetProperty(key)
                    .GetProperties()
                    .FirstOrDefault(p => p.Name.ToLower().Contains(key.ToLower()))
                    .GetValue(db);
                // 

               
                DbSet<TempB> resultTable = (DbSet<TempB>)result;

                var filteredResults = resultTable.Where(l => l.DateTime > startDate).ToList();

                int divider = Math.Max(filteredResults.Count / interval.NumberOfItems,1);


                var filteredResults2 = filteredResults.ToList().Where((i, index) => index % divider == 0);


                logResult.values = filteredResults2.Select(r => new LOGValue() { value = r.Value, time = r.DateTime }).ToList();

                return logResult;
            }

        }

        public class Interval
        {
            private int days = 0;
            public int Days
            {
                get { return - Math.Abs(days); }
                set { days = Math.Abs(value); }
            }
            private int weeks = 0;
            public int Weeks
            {
                get { return -Math.Abs(weeks); }
                set { weeks = Math.Abs(value); }
            }
            private int hours = 0;
            public int Hours
            {
                get { return -Math.Abs(hours); }
                set { hours = Math.Abs(value); }
            }
            private int minutes = 0;
            public int Minutes
            {
                get { return -Math.Abs(minutes); }
                set { minutes = Math.Abs(value); }
            }
            private int seconds = 0;
            public int Seconds
            {
                get { return -Math.Abs(seconds); }
                set { seconds = Math.Abs(value); }
            }

            private int numberOfItems = 20;
            public int NumberOfItems
            {
                get { return numberOfItems; }
                set { numberOfItems = value; }
            }

          

            public Interval(){}

            public DateTime? startTime()
            {
                return DateTime.Now.AddDays(Weeks * 7).AddDays(Days).AddHours(Hours).AddMinutes(Minutes).AddSeconds(Seconds); }


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
                if (selectedParameter != null)
                {
                    selectedParameter.value = value;
                    db.SaveChanges();
                }
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