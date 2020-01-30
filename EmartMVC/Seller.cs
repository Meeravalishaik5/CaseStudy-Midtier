using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class Seller
    {
        [Key]
        public int SID { get; set; }
        public string SUSERNAME { get; set; }
        public string SPASSWORD { get; set; }
        public string SCOMPANYNAME { get; set; }
        public string SGSTIN { get; set; }
        public string SADDRESS { get; set; }
        public string SWEBSITE { get; set; }
        public double SMOBILENO { get; set; }
        public string SEMAILID { get; set; }
    }
}
