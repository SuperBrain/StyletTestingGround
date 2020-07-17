using Stylet;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicMenu.Models
{
    public class MainMenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Screen ViewModel { get; set; }
        public Action Method { get; set; }
    }
}
