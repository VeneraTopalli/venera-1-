using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string gender { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string nationality { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string driverLicense { get; set; }

        public int city { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string bloodGroup { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string country{ get; set; }
    }
}
