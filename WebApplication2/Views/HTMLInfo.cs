using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public static class HTMLInfo
    {
        public static HttpResponseMessage CreateResponse(string title, IEnumerable<ExportParameter> list)
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent(CreateHTML(title, list));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }

        public static HttpResponseMessage CreateResponse(string title, ExportParameter exportParameter)
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent(CreateHTML(title, exportParameter));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }


        private static string CreateHTML(string title, IEnumerable<ExportParameter> list)
        {
            string result = "";

            result += "<html><body>";
            result += "<H1>" + title + "</H1>";

            result += "<table style = 'width: 100 %'>";
            result += "<tr>";
            result += "<th>Description</th>";
            result += "<th>Key</th>";
            result += "</tr>";
            foreach (ExportParameter parameter in list)
            {
                result += "<tr>";
                result += "<td>"+parameter.description + "</td>";
                result += "<td><a href='/api/"+title+"/" + parameter.key + "'>" + parameter.key + "</a></td>";
                result += "</tr>";
            }
            result += "</table>";
            result += "</body></html>";

            return result;

        }

        private static string CreateHTML(string title, ExportParameter exportParameter)
        {
            string result = "";

            result += "<html><body>";
            result += "<H1>" + title + "</H1>";

            result += "<table style = 'width: 100 %'>";
            result += "<tr>";
            result += "<td>";
            result += "key";
            result += "</td>";
            result += "<td>";
            result += exportParameter.key;
            result += "</td>";
            result += "</tr>";

            result += "<tr>";
            result += "<td>";
            result += "description";
            result += "</td>";
            result += "<td>";
            result += exportParameter.description;
            result += "</td>";
            result += "</tr>";

            result += "<tr>";
            result += "<td>";
            result += "value";
            result += "</td>";
            result += "<td>";
            result += exportParameter.Value;
            result += "</td>";
            result += "</tr>";

            result += "<tr>";
            result += "<td>";
            result += "canWrite";
            result += "</td>";
            result += "<td>";
            result += exportParameter.canWrite;
            result += "</td>";
            result += "</tr>";

            result += "<tr>";
            result += "<td>";
            result += "displayType";
            result += "</td>";
            result += "<td>";
            result += exportParameter.displayType;
            result += "</td>";
            result += "</tr>";

            result += "</table>";


 

            result += "</body></html>";


            return result;

        }




    }
}