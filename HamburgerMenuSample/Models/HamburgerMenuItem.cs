using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenuSample.Models
{
    public class HamburgerMenuItem
    {
        public string Title { get; set; } = "Sample Menu Item";
        public string Icon { get; set; } = "\uE10A";
        public Type TargetPage { get; set; }
    }
}
