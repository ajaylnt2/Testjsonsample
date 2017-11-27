using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJsonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.GenerateJSON();
        }

        public void GenerateJSON()
        {
            List<TimeSeriesData> _tsData = new List<TimeSeriesData>();
            for (int i = 0; i < 500; i++)
            {
                var _timeseries = new TimeSeriesData();
                _timeseries.TagName = i % 2 == 0 ? "Alpha" : "Beta";
                _tsData.Add(_timeseries);
            }

            var serialize = JsonConvert.SerializeObject(_tsData);
            System.IO.File.WriteAllText(@"C:\SampleJsonData.txt", serialize);
        }
    }
}
