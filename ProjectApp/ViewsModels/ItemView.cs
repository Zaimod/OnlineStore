using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;

namespace ProjectApp.ViewsModels
{
    public class ItemView
    {
        public Goods item { get; set; }
        public FullDescription_Video video_desk { get; set; }
        public Description description { get; set; }
    }
}
