using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class FullDescription_Video
    {
        public int id { get; set; }
        public int id_goods { get; set; }
        public Goods Goods { get; set; }

        public string Maker { get; set; }
        public string Pruznachennia { get; set; }
        public double Obsyag_Videopamyati { get; set; }
        public string Tip_Videopamyati { get; set; }
        public string Graph_chipset { get; set; }
        public double Rozrydnisct { get; set; }
        public double Chastota_proc { get; set; }
        public double Chastota_video { get; set; }
        public string Tip_pidkluchenna { get; set; }
        public bool display_port { get; set; }
        public bool dvi { get; set; }
        public bool hdmi { get; set; }
        public bool vga { get; set; }
        public double length { get; set; }
        public bool Stan { get; set; }
    }
}
