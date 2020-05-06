using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public class Video
    {
        public int IdVideo { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}