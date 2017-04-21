using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class WeatherApiResponse
    {

        public apiLocation Location { get; set; }
        public apiCurrent Current { get; set; }

        public class apiLocation
        {
            public string Name { get; set; }
            public string Region { get; set; }
            public string Country { get; set; }
            public double Lat { get; set; }
            public double Lon { get; set; }
            public string Tz_id { get; set; }
            public int Localtime_epoch { get; set; }
            public string Localtime { get; set; }
        }

        public class apiCurrent
        {
            public double Temp_c { get; set; }
            public apiCondition condition { get; set; }
            public class apiCondition
            {
                public string Text { get; set; }
                public string Icon { get; set; }
            }
        }