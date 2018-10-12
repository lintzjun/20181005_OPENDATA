using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
//123
namespace _20181005_OPENDATA
{
    public class HolidayOpenData
    {
        public bool success { get; set; }
        public Result result { get; set; }
    }
    
    public class Result
    {
        public string resource_id { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public Field[] fields { get; set; }
        public Record[] records { get; set; }
    }

    public class Field
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    public class Record
    {
        public string date { get; set; }
        public string name { get; set; }
        public string isHoliday { get; set; }
        public string holidayCategory { get; set; }
        public string description { get; set; }
    }




}
