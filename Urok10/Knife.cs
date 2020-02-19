using System;
using System.Collections.Generic;
using System.Text;

namespace Urok10
{
    public class Knife:Weapon
    {
        public string Sharpness { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Sharpness: {Sharpness}");
        }
    }
}
