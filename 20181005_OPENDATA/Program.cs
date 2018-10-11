using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _20181005_OPENDATA
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://data.ntpc.gov.tw/api/v1/rest/datastore/382000000A-000077-002";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json;charset=UTF-8";
            var response = request.GetResponse() as HttpWebResponse;
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
            var srcString = reader.ReadToEnd();
            var jsonData = Newtonsoft.Json.JsonConvert
                .DeserializeObject<HolidayOpenData>(srcString);
            foreach (var holiday in jsonData.result.records)
            {
                Console.WriteLine($"Date: {holiday.date}, IsHoliday: {holiday.isHoliday}, Category: {holiday.holidayCategory}");
            }
            Console.ReadKey();
        }
    }
}