using System;
using System.Collections.Generic;
using System.Text;

namespace Urok10
{
    public class Sword:Weapon
    {
        public string Lenght { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Lenght: {Lenght}");
        }
    }
}
