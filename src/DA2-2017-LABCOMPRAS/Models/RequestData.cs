using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class RequestData
    {
        
            private double amount;
            private string from;
            private string to;

            [Required(ErrorMessage = "Please Insert this value")]
            public double Amount
            {
                get { return amount; }
                set { amount = value; }
            }

            [Required(ErrorMessage = "Please Insert this value")]
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


            public RequestData()
            {
             
            }


        }
    }

    
