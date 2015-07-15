using HamburgerMenuSample.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenuSample.Models
{
    public class MainHamburgerMenu : List<HamburgerMenuItem>
    {
        public MainHamburgerMenu() : base()
        {
            Add(new HamburgerMenuItem() { TargetPage = typeof(DefaultPage), Title = "Home", Icon = "\uE10F" });
            Add(new HamburgerMenuItem() { TargetPage = typeof(DefaultPage), Title = "Search", Icon = "\uE11A" });
            Add(new HamburgerMenuItem() { TargetPage = typeof(DefaultPage), Title = "Coding is fun", Icon = "\uE148" });
        }
    }
}
