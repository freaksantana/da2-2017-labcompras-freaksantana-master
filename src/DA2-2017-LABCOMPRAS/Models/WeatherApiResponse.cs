using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class WeatherApiResponse
    {
        public apilocation Location
        {
            get { return Location; }
            set { Location = value; }

        }
        public apicurrent Current
        {
            get { return Current; }
            set { Current = value; }
        }

      public class apilocation
        {
          
        }

        public class apicurrent
        {

        }
    }
}
