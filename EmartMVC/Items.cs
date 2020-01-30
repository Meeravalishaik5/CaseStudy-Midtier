using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class Items
    {
        [Key]
        public int IID { get; set; }
        public int CID { get; set; }
        public int SCID { get; set; }
        public string INAME { get; set; }
        public double IPRICE { get; set; }
        public string ABOUTITEM { get; set; }
        public int STOCK { get; set; }
        public string remarks { get; set; }
        public byte[] image { get; set; }

    }
}
