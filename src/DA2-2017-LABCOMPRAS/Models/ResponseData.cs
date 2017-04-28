using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class ResponseData
    {
        
            private double amount;
            private string from;
            private string to;
            private double convertedAmount;

            public double Amount
            {
                get { return amount; }
                set { amount = value; }
            }

            public string From
            {
                get { return from; }
                set { from = value; }
            }

            public string To
            {
                get { return to; }
                set { to = value; }
            }

        public double ConvertedAmount
        {
            get { return convertedAmount; }
            set { convertedAmount = value; }
        }


        public ResponseData()
            {
             
            }


        }
    }

    
