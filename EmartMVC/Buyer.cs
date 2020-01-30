using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class Buyer
    {
        [Key]
        public int BID { get; set; }
        public string BUSERNAME { get; set; }
        public string BPASSWORD { get; set; }
        public string BEMAILID { get; set; }
        public double BMOBILENO { get; set; }
        public DateTime BLDT { get; set; }    
    }
}
